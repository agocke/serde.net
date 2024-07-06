namespace Serde.Test;
partial class JsonDeserializeTests
{
    internal static class ThrowMissingFalseSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "ThrowMissingFalse",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("present", typeof(Serde.Test.JsonDeserializeTests.ThrowMissingFalse).GetProperty("Present")!),
new("missing", typeof(Serde.Test.JsonDeserializeTests.ThrowMissingFalse).GetProperty("Missing")!)
    });
}
}