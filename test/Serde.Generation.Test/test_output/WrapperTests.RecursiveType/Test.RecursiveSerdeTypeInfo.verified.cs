//HintName: Test.RecursiveSerdeTypeInfo.cs
namespace Test;
internal static class RecursiveSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "Recursive",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("next", typeof(Recursive).GetProperty("Next")!)
    });
}