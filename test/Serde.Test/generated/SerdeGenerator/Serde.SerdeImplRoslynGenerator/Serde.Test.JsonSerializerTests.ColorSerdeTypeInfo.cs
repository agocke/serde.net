namespace Serde.Test;
partial class JsonSerializerTests
{
    internal static class ColorSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "Color",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("red", typeof(Serde.Test.JsonSerializerTests.Color).GetField("Red")!),
new("green", typeof(Serde.Test.JsonSerializerTests.Color).GetField("Green")!),
new("blue", typeof(Serde.Test.JsonSerializerTests.Color).GetField("Blue")!)
    });
}
}