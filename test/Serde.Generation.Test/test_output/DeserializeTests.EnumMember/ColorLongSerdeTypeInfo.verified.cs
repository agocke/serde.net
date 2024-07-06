//HintName: ColorLongSerdeTypeInfo.cs
internal static class ColorLongSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "ColorLong",
        Serde.TypeInfo.TypeKind.Enum,
        new Serde.TypeInfo.FieldInfo[] {
new("red", typeof(ColorLong).GetField("Red")!),
new("green", typeof(ColorLong).GetField("Green")!),
new("blue", typeof(ColorLong).GetField("Blue")!)
    });
}