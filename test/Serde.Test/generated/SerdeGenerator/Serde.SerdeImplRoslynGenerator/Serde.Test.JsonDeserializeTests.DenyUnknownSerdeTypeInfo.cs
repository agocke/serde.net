namespace Serde.Test;
partial class JsonDeserializeTests
{
    internal static class DenyUnknownSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "DenyUnknown",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("present", typeof(Serde.Test.JsonDeserializeTests.DenyUnknown).GetProperty("Present")!),
new("missing", typeof(Serde.Test.JsonDeserializeTests.DenyUnknown).GetProperty("Missing")!)
    });
}
}