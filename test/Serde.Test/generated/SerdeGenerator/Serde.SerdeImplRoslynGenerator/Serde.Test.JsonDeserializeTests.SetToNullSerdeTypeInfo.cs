namespace Serde.Test;
partial class JsonDeserializeTests
{
    internal static class SetToNullSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "SetToNull",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("present", typeof(Serde.Test.JsonDeserializeTests.SetToNull).GetProperty("Present")!),
new("missing", typeof(Serde.Test.JsonDeserializeTests.SetToNull).GetProperty("Missing")!)
    });
}
}