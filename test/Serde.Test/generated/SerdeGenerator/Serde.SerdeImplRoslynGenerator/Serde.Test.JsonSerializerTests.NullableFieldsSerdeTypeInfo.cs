namespace Serde.Test;
partial class JsonSerializerTests
{
    internal static class NullableFieldsSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "NullableFields",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("s", typeof(Serde.Test.JsonSerializerTests.NullableFields).GetField("S")!),
new("d", typeof(Serde.Test.JsonSerializerTests.NullableFields).GetField("D")!)
    });
}
}