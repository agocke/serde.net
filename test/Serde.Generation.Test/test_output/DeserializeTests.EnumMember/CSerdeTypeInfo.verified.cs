//HintName: CSerdeTypeInfo.cs
internal static class CSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "C",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("colorInt", typeof(C).GetField("ColorInt")!),
new("colorByte", typeof(C).GetField("ColorByte")!),
new("colorLong", typeof(C).GetField("ColorLong")!),
new("colorULong", typeof(C).GetField("ColorULong")!)
    });
}