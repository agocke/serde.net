//HintName: RSerdeTypeInfo.cs
internal static class RSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "R",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("a", typeof(R).GetProperty("A")!),
new("b", typeof(R).GetProperty("B")!)
    });
}