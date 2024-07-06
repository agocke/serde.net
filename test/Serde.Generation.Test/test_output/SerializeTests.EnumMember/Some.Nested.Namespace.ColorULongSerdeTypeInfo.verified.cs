//HintName: Some.Nested.Namespace.ColorULongSerdeTypeInfo.cs
namespace Some.Nested.Namespace;
internal static class ColorULongSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "ColorULong",
        Serde.TypeInfo.TypeKind.Enum,
        new Serde.TypeInfo.FieldInfo[] {
new("red", typeof(Some.Nested.Namespace.ColorULong).GetField("Red")!),
new("green", typeof(Some.Nested.Namespace.ColorULong).GetField("Green")!),
new("blue", typeof(Some.Nested.Namespace.ColorULong).GetField("Blue")!)
    });
}