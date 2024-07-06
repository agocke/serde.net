//HintName: ColorByteSerdeTypeInfo.cs
internal static class ColorByteSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "ColorByte",
        Serde.TypeInfo.TypeKind.Enum,
        new Serde.TypeInfo.FieldInfo[] {
new("red", typeof(ColorByte).GetField("Red")!),
new("green", typeof(ColorByte).GetField("Green")!),
new("blue", typeof(ColorByte).GetField("Blue")!)
    });
}