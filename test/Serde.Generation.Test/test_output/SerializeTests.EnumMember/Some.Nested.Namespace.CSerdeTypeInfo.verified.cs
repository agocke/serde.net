//HintName: Some.Nested.Namespace.CSerdeTypeInfo.cs
namespace Some.Nested.Namespace;
internal static class CSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "C",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("colorInt", typeof(Some.Nested.Namespace.C).GetField("ColorInt")!),
new("colorByte", typeof(Some.Nested.Namespace.C).GetField("ColorByte")!),
new("colorLong", typeof(Some.Nested.Namespace.C).GetField("ColorLong")!),
new("colorULong", typeof(Some.Nested.Namespace.C).GetField("ColorULong")!)
    });
}