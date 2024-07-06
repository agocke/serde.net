namespace Serde.Test;
partial class XmlTests
{
    internal static class BoolStructSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "BoolStruct",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("BoolField", typeof(Serde.Test.XmlTests.BoolStruct).GetField("BoolField")!)
    });
}
}