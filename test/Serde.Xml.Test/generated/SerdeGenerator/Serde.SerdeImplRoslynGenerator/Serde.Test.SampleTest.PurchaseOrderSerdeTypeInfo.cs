namespace Serde.Test;
partial class SampleTest
{
    internal static class PurchaseOrderSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "PurchaseOrder",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("ShipTo", typeof(Serde.Test.SampleTest.PurchaseOrder).GetField("ShipTo")!),
new("OrderDate", typeof(Serde.Test.SampleTest.PurchaseOrder).GetField("OrderDate")!),
new("Items", typeof(Serde.Test.SampleTest.PurchaseOrder).GetField("OrderedItems")!),
new("SubTotal", typeof(Serde.Test.SampleTest.PurchaseOrder).GetField("SubTotal")!),
new("ShipCost", typeof(Serde.Test.SampleTest.PurchaseOrder).GetField("ShipCost")!),
new("TotalCost", typeof(Serde.Test.SampleTest.PurchaseOrder).GetField("TotalCost")!)
    });
}
}