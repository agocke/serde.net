
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace Serde.Json;

internal sealed partial class Deserializer(ReadOnlyMemory<byte> source) : IDeserializer
{
    private readonly Utf8Reader _reader = new(source);
    private readonly List<byte> _scratch = new();
}

partial class Deserializer : IDeserializer
{
    public static Deserializer FromString(string s)
    {
        return new Deserializer(Encoding.UTF8.GetBytes(s));
    }

    public T DeserializeAny<T, V>(V v) where V : IDeserializeVisitor<T>
    {
        var c = ThrowIfEof(_reader.PeekNonWhitespace());

        switch (c)
        {
            case (byte)'n':
                _reader.AdvanceChar();
                ParseIdent("ull"u8);
                return v.VisitNull();
            case >= (byte)'0' and <= (byte)'9':
                return ParseNumber<T, V>(v);
            case (byte)'"':
                _reader.AdvanceChar();
                _scratch.Clear();
                var stringOrSpan = _reader.ParseString<T, V>(_scratch, v);
                return stringOrSpan.Tag switch
                {
                    StringOrSpan.TagType.String => v.VisitString(stringOrSpan.String),
                    StringOrSpan.TagType.Span => v.VisitUtf8Span(stringOrSpan.Span),
                };
            case (byte)'{':
                _reader.AdvanceChar();
                var deDict = new DeDictionary(this);
                return v.VisitDictionary(ref deDict);
            default:
                throw new InvalidDeserializeValueException("Unexpected character: " + (char)c);
        }
    }

    private T ParseNumber<T, V>(V v) where V : IDeserializeVisitor<T>
    {
        throw new NotImplementedException();
    }

    private bool ParseIdent(Utf8Span readOnlySpan)
    {
        throw new NotImplementedException();
    }

    private struct DeDictionary(Deserializer _deserializer) : IDeserializeDictionary
    {
        private bool _first = true;

        public int? SizeOpt => null;

        public bool TryGetNextEntry<K, DK, V, DV>([MaybeNullWhen(false)] out (K, V) next)
            where DK : IDeserialize<K>
            where DV : IDeserialize<V>
        {
            // Don't save state
            if (!TryGetNextKey<K, DK>(out K? nextKey))
            {
                next = default;
                return false;
            }
            var nextValue = GetNextValue<V, DV>();
            next = (nextKey, nextValue);
            return true;
        }

        public bool TryGetNextKey<K, D>([MaybeNullWhen(false)] out K next) where D : IDeserialize<K>
        {
            while (true)
            {
                var c = _deserializer.ThrowIfEof(_deserializer._reader.PeekNonWhitespace());
                short peek;
                switch (c)
                {
                    case (byte)'}':
                        next = default;
                        return false;
                    case (byte)',' when !_first:
                        _deserializer._reader.AdvanceChar();
                        peek = _deserializer._reader.PeekNonWhitespace();
                        break;
                    default:
                        if (_first)
                        {
                            _first = false;
                            peek = c;
                        }
                        else
                        {
                            throw new InvalidDeserializeValueException("Expected ',' or '}', got " + (char)c);
                        }
                        break;
                }
                var ret = _deserializer.ThrowIfEof(peek);
                switch (ret) {
                    case (byte)'"':
                        next = D.Deserialize(ref _deserializer);
                        return true;
                    case (byte)'}':
                        throw new InvalidDeserializeValueException("Trailing comma");
                    default:
                        throw new InvalidDeserializeValueException("Unexpected character: " + (char)ret);
                }
            }
        }

        public V GetNextValue<V, D>() where D : IDeserialize<V>
        {
            _deserializer.ParseObjectColon();
            return D.Deserialize(ref _deserializer);
        }
    }

    private void ParseObjectColon()
    {
        var c = ThrowIfEof(_reader.PeekNonWhitespace());
        switch (c)
        {
            case (byte)':':
                _reader.AdvanceChar();
                break;
            default:
                throw new InvalidDeserializeValueException("Expected ':', got " + (char)c);
        }
    }

    public T DeserializeBool<T, V>(V v) where V : IDeserializeVisitor<T>
    {
        throw new NotImplementedException();
    }

    public T DeserializeByte<T, V>(V v) where V : IDeserializeVisitor<T>
    {
        throw new NotImplementedException();
    }

    public T DeserializeChar<T, V>(V v) where V : IDeserializeVisitor<T>
    {
        throw new NotImplementedException();
    }

    public T DeserializeDecimal<T, V>(V v) where V : IDeserializeVisitor<T>
    {
        throw new NotImplementedException();
    }

    public T DeserializeDictionary<T, V>(V v) where V : IDeserializeVisitor<T>
    {
        var peek = ThrowIfEof(_reader.PeekNonWhitespace());
        switch (peek)
        {
            case (byte)'{':
                _reader.AdvanceChar();
                var deDict = new DeDictionary(this);
                var ret = v.VisitDictionary(ref deDict);
                _reader.EndDict();
                return ret;
            default:
                throw new InvalidDeserializeValueException("Unexpected character: " + (char)peek);
        }
    }

    public T DeserializeDouble<T, V>(V v) where V : IDeserializeVisitor<T>
    {
        throw new NotImplementedException();
    }

    public T DeserializeEnumerable<T, V>(V v) where V : IDeserializeVisitor<T>
    {
        throw new NotImplementedException();
    }

    public T DeserializeFloat<T, V>(V v) where V : IDeserializeVisitor<T>
    {
        throw new NotImplementedException();
    }

    public T DeserializeI16<T, V>(V v) where V : IDeserializeVisitor<T>
    {
        throw new NotImplementedException();
    }

    public T DeserializeI32<T, V>(V v) where V : IDeserializeVisitor<T>
        => DeserializeI64<T, V>(v);

    public T DeserializeI64<T, V>(V v) where V : IDeserializeVisitor<T>
    {
        var peek = _reader.PeekNonWhitespace();
        if (peek == (byte)'-')
        {
            _reader.AdvanceChar();
            return ParseAndVisitInteger<T, V>(v, false);
        }
        return ParseAndVisitInteger<T, V>(v, true);
    }

    private byte PeekOrNull()
    {
        var c = _reader.PeekChar();
        if (c != Utf8Reader.EofChar)
        {
            return (byte)c;
        }
        return (byte)'\x00';
    }

    private T ParseAndVisitInteger<T, V>(V v, bool positive) where V : IDeserializeVisitor<T>
    {
        var next = ThrowIfEof(_reader.NextChar());

        switch (next)
        {
            case (byte)'0':
                throw new NotImplementedException("Leading zeroes not yet supported");
            case >= (byte)'1' and <= (byte)'9':
                long significand = next - (byte)'0';

                while (true)
                {
                    switch (PeekOrNull())
                    {
                        case var c and >= (byte)'0' and <= (byte)'9':
                            var digit = c - (byte)'0';

                            // We need to be careful with overflow. If we can,
                            // try to keep the number as a `u64` until we grow
                            // too large. At that point, switch to parsing the
                            // value as a `decimal`.
                            try
                            {
                                significand = checked(significand * 10 + digit);
                            }
                            catch (OverflowException)
                            {
                                return ParseAndVisitDecimal<T, V>(v, positive, significand);
                            }

                            _reader.AdvanceChar();
                            break;
                        default:
                            return v.VisitI64(positive ? significand : -significand);
                    }
                }
            default:
                throw new InvalidDeserializeValueException("Invalid number. Unexpected character: " + (char)next);
        }
    }

    private T ParseAndVisitDecimal<T, V>(V v, bool positive, long significand) where V : IDeserializeVisitor<T>
    {
        throw new NotImplementedException();
    }

    public T DeserializeIdentifier<T, V>(V v) where V : IDeserializeVisitor<T>
    {
        throw new NotImplementedException();
    }

    public T DeserializeNullableRef<T, V>(V v) where V : IDeserializeVisitor<T>
    {
        throw new NotImplementedException();
    }

    public T DeserializeSByte<T, V>(V v) where V : IDeserializeVisitor<T>
    {
        throw new NotImplementedException();
    }

    public T DeserializeString<T, V>(V v) where V : IDeserializeVisitor<T>
    {
        var peek = ThrowIfEof(_reader.PeekNonWhitespace());

        switch (peek)
        {
            case (byte)'"':
                _reader.AdvanceChar();
                _scratch.Clear();
                var stringOrSpan = _reader.ParseString<T, V>(_scratch, v);
                return stringOrSpan.Tag switch
                {
                    StringOrSpan.TagType.String => v.VisitString(stringOrSpan.String),
                    StringOrSpan.TagType.Span => v.VisitUtf8Span(stringOrSpan.Span),
                };
            default:
                throw new InvalidDeserializeValueException("Unexpected character: " + (char)peek);
        }
    }

    public T DeserializeType<T, V>(string typeName, ReadOnlySpan<string> fieldNames, V v) where V : IDeserializeVisitor<T>
    {
        // Types are identical to dictionaries
        return DeserializeDictionary<T, V>(v);
    }

    public T DeserializeU16<T, V>(V v) where V : IDeserializeVisitor<T>
    {
        throw new NotImplementedException();
    }

    public T DeserializeU32<T, V>(V v) where V : IDeserializeVisitor<T>
    {
        throw new NotImplementedException();
    }

    public T DeserializeU64<T, V>(V v) where V : IDeserializeVisitor<T>
    {
        throw new NotImplementedException();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public byte ThrowIfEof(short s)
    {
        if (s == Utf8Reader.EofChar)
        {
            DeserializerThrowHelper.ThrowUnexpectedEof();
        }
        return (byte)s;
    }
}