namespace Serde.Test;
partial class SampleTest
{
    internal static class AddressSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "Address",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("Name", typeof(Serde.Test.SampleTest.Address).GetField("Name")!),
new("Line1", typeof(Serde.Test.SampleTest.Address).GetField("Line1")!),
new("City", typeof(Serde.Test.SampleTest.Address).GetField("City")!),
new("State", typeof(Serde.Test.SampleTest.Address).GetField("State")!),
new("Zip", typeof(Serde.Test.SampleTest.Address).GetField("Zip")!)
    });
}
}