namespace Serde.Test;
partial class JsonDeserializeTests
{
    internal static class IdStructSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "IdStruct",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("id", typeof(Serde.Test.JsonDeserializeTests.IdStruct).GetField("Id")!)
    });
}
}