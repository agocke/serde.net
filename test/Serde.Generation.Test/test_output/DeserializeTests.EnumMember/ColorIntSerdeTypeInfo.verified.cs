//HintName: ColorIntSerdeTypeInfo.cs
internal static class ColorIntSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "ColorInt",
        Serde.TypeInfo.TypeKind.Enum,
        new Serde.TypeInfo.FieldInfo[] {
new("red", typeof(ColorInt).GetField("Red")!),
new("green", typeof(ColorInt).GetField("Green")!),
new("blue", typeof(ColorInt).GetField("Blue")!)
    });
}