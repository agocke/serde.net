//HintName: ArrayFieldSerdeTypeInfo.cs
internal static class ArrayFieldSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "ArrayField",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("intArr", typeof(ArrayField).GetField("IntArr")!)
    });
}