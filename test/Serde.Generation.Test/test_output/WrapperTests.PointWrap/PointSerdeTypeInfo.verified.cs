//HintName: PointSerdeTypeInfo.cs
internal static class PointSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "Point",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("x", typeof(Point).GetField("X")!),
new("y", typeof(Point).GetField("Y")!)
    });
}