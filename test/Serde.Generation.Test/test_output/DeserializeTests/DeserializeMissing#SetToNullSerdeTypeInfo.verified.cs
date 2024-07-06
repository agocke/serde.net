//HintName: SetToNullSerdeTypeInfo.cs
internal static class SetToNullSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "SetToNull",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("present", typeof(SetToNull).GetProperty("Present")!),
new("missing", typeof(SetToNull).GetProperty("Missing")!),
new("throwMissing", typeof(SetToNull).GetProperty("ThrowMissing")!)
    });
}