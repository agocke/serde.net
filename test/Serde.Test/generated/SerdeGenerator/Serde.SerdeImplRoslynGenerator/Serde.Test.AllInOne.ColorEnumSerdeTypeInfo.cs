namespace Serde.Test;
partial record AllInOne
{
    internal static class ColorEnumSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "ColorEnum",
        Serde.TypeInfo.TypeKind.Enum,
        new Serde.TypeInfo.FieldInfo[] {
new("red", typeof(Serde.Test.AllInOne.ColorEnum).GetField("Red")!),
new("blue", typeof(Serde.Test.AllInOne.ColorEnum).GetField("Blue")!),
new("green", typeof(Serde.Test.AllInOne.ColorEnum).GetField("Green")!)
    });
}
}