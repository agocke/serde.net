namespace Serde.Test;
partial class CustomImplTests
{
    internal static class RgbWithFieldMapSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "RgbWithFieldMap",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("red", typeof(Serde.Test.CustomImplTests.RgbWithFieldMap).GetField("Red")!),
new("green", typeof(Serde.Test.CustomImplTests.RgbWithFieldMap).GetField("Green")!),
new("blue", typeof(Serde.Test.CustomImplTests.RgbWithFieldMap).GetField("Blue")!)
    });
}
}