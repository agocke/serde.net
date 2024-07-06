namespace Serde.Test;
partial class XmlTests
{
    internal static class MapTest1SerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "MapTest1",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("MapField", typeof(Serde.Test.XmlTests.MapTest1).GetField("MapField")!)
    });
}
}