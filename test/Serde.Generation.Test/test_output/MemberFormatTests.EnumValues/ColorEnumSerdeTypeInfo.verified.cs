//HintName: ColorEnumSerdeTypeInfo.cs
internal static class ColorEnumSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "ColorEnum",
        Serde.TypeInfo.TypeKind.Enum,
        new Serde.TypeInfo.FieldInfo[] {
new("red", typeof(ColorEnum).GetField("Red")!),
new("green", typeof(ColorEnum).GetField("Green")!),
new("blue", typeof(ColorEnum).GetField("Blue")!)
    });
}