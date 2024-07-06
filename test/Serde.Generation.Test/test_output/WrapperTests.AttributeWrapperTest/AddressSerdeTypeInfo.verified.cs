//HintName: AddressSerdeTypeInfo.cs
internal static class AddressSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "Address",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("name", typeof(Address).GetField("Name")!),
new("line1", typeof(Address).GetField("Line1")!),
new("city", typeof(Address).GetField("City")!),
new("state", typeof(Address).GetField("State")!),
new("zip", typeof(Address).GetField("Zip")!)
    });
}