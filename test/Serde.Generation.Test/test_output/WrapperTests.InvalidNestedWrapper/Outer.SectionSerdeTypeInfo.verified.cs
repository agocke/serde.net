//HintName: Outer.SectionSerdeTypeInfo.cs
partial class Outer
{
    internal static class SectionSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "Section",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("mask", typeof(System.Collections.Specialized.BitVector32.Section).GetProperty("Mask")!),
new("offset", typeof(System.Collections.Specialized.BitVector32.Section).GetProperty("Offset")!)
    });
}
}