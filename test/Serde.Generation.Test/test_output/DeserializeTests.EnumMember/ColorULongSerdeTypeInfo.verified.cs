//HintName: ColorULongSerdeTypeInfo.cs
internal static class ColorULongSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "ColorULong",
        Serde.TypeInfo.TypeKind.Enum,
        new Serde.TypeInfo.FieldInfo[] {
new("red", typeof(ColorULong).GetField("Red")!),
new("green", typeof(ColorULong).GetField("Green")!),
new("blue", typeof(ColorULong).GetField("Blue")!)
    });
}