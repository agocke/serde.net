//HintName: ColorEnumSerdeTypeInfo.cs
internal static class ColorEnumSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "ColorEnum",
        Serde.TypeInfo.TypeKind.Enum,
        new Serde.TypeInfo.FieldInfo[] {
new("Red", typeof(ColorEnum).GetField("Red")!),
new("Green", typeof(ColorEnum).GetField("Green")!),
new("Blue", typeof(ColorEnum).GetField("Blue")!)
    });
}