//HintName: Some.Nested.Namespace.ColorIntSerdeTypeInfo.cs
namespace Some.Nested.Namespace;
internal static class ColorIntSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "ColorInt",
        Serde.TypeInfo.TypeKind.Enum,
        new Serde.TypeInfo.FieldInfo[] {
new("red", typeof(Some.Nested.Namespace.ColorInt).GetField("Red")!),
new("green", typeof(Some.Nested.Namespace.ColorInt).GetField("Green")!),
new("blue", typeof(Some.Nested.Namespace.ColorInt).GetField("Blue")!)
    });
}