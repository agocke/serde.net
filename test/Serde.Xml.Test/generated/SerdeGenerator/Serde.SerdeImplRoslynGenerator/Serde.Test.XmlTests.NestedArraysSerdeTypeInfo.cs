namespace Serde.Test;
partial class XmlTests
{
    internal static class NestedArraysSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "NestedArrays",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("A", typeof(Serde.Test.XmlTests.NestedArrays).GetField("A")!)
    });
}
}