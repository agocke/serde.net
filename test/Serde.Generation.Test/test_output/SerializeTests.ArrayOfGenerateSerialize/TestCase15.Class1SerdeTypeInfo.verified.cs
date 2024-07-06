//HintName: TestCase15.Class1SerdeTypeInfo.cs
partial class TestCase15
{
    internal static class Class1SerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "Class1",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("field0", typeof(TestCase15.Class1).GetField("Field0")!),
new("field1", typeof(TestCase15.Class1).GetField("Field1")!)
    });
}
}