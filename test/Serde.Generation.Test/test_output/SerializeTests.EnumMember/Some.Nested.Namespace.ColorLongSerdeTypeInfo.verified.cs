//HintName: Some.Nested.Namespace.ColorLongSerdeTypeInfo.cs
namespace Some.Nested.Namespace;
internal static class ColorLongSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "ColorLong",
        Serde.TypeInfo.TypeKind.Enum,
        new Serde.TypeInfo.FieldInfo[] {
new("red", typeof(Some.Nested.Namespace.ColorLong).GetField("Red")!),
new("green", typeof(Some.Nested.Namespace.ColorLong).GetField("Green")!),
new("blue", typeof(Some.Nested.Namespace.ColorLong).GetField("Blue")!)
    });
}