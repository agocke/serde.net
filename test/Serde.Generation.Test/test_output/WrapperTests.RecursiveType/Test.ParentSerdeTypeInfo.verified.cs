//HintName: Test.ParentSerdeTypeInfo.cs
namespace Test;
internal static class ParentSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "Parent",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("r", typeof(Test.Parent).GetProperty("R")!)
    });
}