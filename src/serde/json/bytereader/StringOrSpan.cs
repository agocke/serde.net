
using System;
using StaticCs;

namespace Serde.Json
{
    internal ref struct StringOrSpan
    {
        [Closed]
        public enum TagType { String, Span }

        public TagType Tag { get; }

        public string String { get; }
        public Utf8Span Span { get; }

        public StringOrSpan(string s)
        {
            Tag = TagType.String;
            String = s;
            Span = default;
        }

        public StringOrSpan(Utf8Span s)
        {
            Tag = TagType.Span;
            String = default!;
            Span = s;
        }
    }
}