//HintName: RgbSerdeTypeInfo.cs
internal static class RgbSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "Rgb",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("red", typeof(Rgb).GetField("Red")!),
new("green", typeof(Rgb).GetField("Green")!),
new("blue", typeof(Rgb).GetField("Blue")!)
    });
}