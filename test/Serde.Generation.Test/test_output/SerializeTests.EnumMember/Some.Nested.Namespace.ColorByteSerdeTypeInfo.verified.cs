//HintName: Some.Nested.Namespace.ColorByteSerdeTypeInfo.cs
namespace Some.Nested.Namespace;
internal static class ColorByteSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "ColorByte",
        Serde.TypeInfo.TypeKind.Enum,
        new Serde.TypeInfo.FieldInfo[] {
new("red", typeof(Some.Nested.Namespace.ColorByte).GetField("Red")!),
new("green", typeof(Some.Nested.Namespace.ColorByte).GetField("Green")!),
new("blue", typeof(Some.Nested.Namespace.ColorByte).GetField("Blue")!)
    });
}