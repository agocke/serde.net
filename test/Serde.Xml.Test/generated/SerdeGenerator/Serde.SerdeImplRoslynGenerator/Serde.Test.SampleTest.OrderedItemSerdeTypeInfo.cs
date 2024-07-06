namespace Serde.Test;
partial class SampleTest
{
    internal static class OrderedItemSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "OrderedItem",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("ItemName", typeof(Serde.Test.SampleTest.OrderedItem).GetField("ItemName")!),
new("Description", typeof(Serde.Test.SampleTest.OrderedItem).GetField("Description")!),
new("UnitPrice", typeof(Serde.Test.SampleTest.OrderedItem).GetField("UnitPrice")!),
new("Quantity", typeof(Serde.Test.SampleTest.OrderedItem).GetField("Quantity")!),
new("LineTotal", typeof(Serde.Test.SampleTest.OrderedItem).GetField("LineTotal")!)
    });
}
}