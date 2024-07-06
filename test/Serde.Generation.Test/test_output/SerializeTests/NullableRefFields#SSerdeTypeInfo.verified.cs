//HintName: SSerdeTypeInfo.cs
internal static class SSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "S",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("fS", typeof(S<,,,,>).GetField("FS")!),
new("f1", typeof(S<,,,,>).GetField("F1")!),
new("f2", typeof(S<,,,,>).GetField("F2")!),
new("f3", typeof(S<,,,,>).GetField("F3")!),
new("f4", typeof(S<,,,,>).GetField("F4")!)
    });
}