
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Serde.Json;

internal sealed class Utf8Reader(ReadOnlyMemory<byte> source)
{
    private readonly ReadOnlyMemory<byte> _mem = source;
    private int _pos = 0;

    public byte? PeekChar()
    {
        if (_pos >= _mem.Length)
        {
            return null;
        }
        return _mem.Span[_pos];
    }

    /// <summary>
    /// Grab the next character and advance the position.
    /// </summary>
    public byte? NextChar()
    {
        var c = PeekChar();
        if (c != null)
        {
            AdvanceChar();
        }
        return c;
    }

    public void AdvanceChar()
    {
        _pos++;
    }

    /// <summary>
    /// Advance the position until we find a non-whitespace character and return it.
    /// Null if we reach the end of the input.
    /// </summary>
    public byte? PeekNonWhitespace()
    {
        while (true)
        {
            var c = PeekChar();
            switch (c)
            {
                case null:
                    return null;
                case (byte)' ':
                case (byte)'\t':
                case (byte)'\n':
                case (byte)'\r':
                    AdvanceChar();
                    break;
                default:
                    return c;
            }
        }
    }

    public void EndDict()
    {
        switch (PeekNonWhitespace())
        {
            case (byte)'}':
                AdvanceChar();
                break;
            case null:
                ThrowJsonException("EOF while reading dictionary");
                break;
            case (byte)',':
                ThrowJsonException("Unexpected trailing comma");
                break;
            case var c:
                ThrowJsonException("Unexpected trailing character '" + (char)c + "'");
                break;
        }
    }

    public StringOrSpan ParseString<T, V>(List<byte> scratch, V v) where V : IDeserializeVisitor<T>
    {
        return new StringOrSpan(ParseUtf8Span(scratch));
    }

    /// <summary>
    /// Parse a UTF-8 string from the input. If there are no escape sequences, use a span directly from
    /// the input. Otherwise, copy the string into a scratch buffer and return that.
    /// </summary>
    private Utf8Span ParseUtf8Span(List<byte> scratch)
    {
        var start = _pos;
        var span = _mem.Span;

        while (true)
        {
            while (_pos < span.Length && !IsEscape[span[_pos]])
            {
                _pos++;
            }
            if (_pos >= _mem.Length)
            {
                ThrowJsonException("EOF while reading string");
            }
            var stringSpan = span[start.._pos];
            switch (span[_pos])
            {
                case (byte)'"':
                    if (scratch.Count == 0)
                    {
                        // No escape sequences, so we can use the input buffer directly.
                        _pos++;
                        return stringSpan;
                    }
                    else
                    {
                        AddRange(scratch, stringSpan);
                        _pos++;
                        return CollectionsMarshal.AsSpan(scratch);
                    }
                case (byte)'\\':
                    AddRange(scratch, stringSpan);
                    _pos++;
                    ParseEscape(scratch);
                    start = _pos;
                    break;
                default:
                    _pos++;
                    ThrowJsonException($"Unexpected character '{(char)span[_pos]}' while reading string");
                    break;
            }
        }
    }

    private void ParseEscape(List<byte> scratch)
    {
        throw new NotImplementedException();
    }

    private static void AddRange(List<byte> list, Utf8Span span)
    {
        foreach (var b in span)
        {
            list.Add(b);
        }
    }

    // Lookup table of bytes that must be escaped. A value of true at index i means
    // that byte i requires an escape sequence in the input.
    const bool CT = true; // control character \x00..=\x1F
    const bool QU = true; // quote \x22
    const bool BS = true; // backslash \x5C
    const bool __ = false; // allow unescaped

    static ReadOnlySpan<bool> IsEscape => [
        //   1   2   3   4   5   6   7   8   9   A   B   C   D   E   F
        CT, CT, CT, CT, CT, CT, CT, CT, CT, CT, CT, CT, CT, CT, CT, CT, // 0
        CT, CT, CT, CT, CT, CT, CT, CT, CT, CT, CT, CT, CT, CT, CT, CT, // 1
        __, __, QU, __, __, __, __, __, __, __, __, __, __, __, __, __, // 2
        __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, // 3
        __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, // 4
        __, __, __, __, __, __, __, __, __, __, __, __, BS, __, __, __, // 5
        __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, // 6
        __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, // 7
        __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, // 8
        __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, // 9
        __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, // A
        __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, // B
        __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, // C
        __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, // D
        __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, // E
        __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, __, // F
    ];

    [DoesNotReturn]
    private void ThrowJsonException(string message)
    {
        throw GetJsonException(message);
    }

    private JsonException GetJsonException(string message)
    {
        return new JsonException(message, path: null, lineNumber: null, bytePositionInLine: _pos);
    }
}