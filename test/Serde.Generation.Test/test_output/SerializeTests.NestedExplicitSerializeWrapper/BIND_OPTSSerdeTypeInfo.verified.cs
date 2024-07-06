//HintName: BIND_OPTSSerdeTypeInfo.cs
internal static class BIND_OPTSSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "BIND_OPTS",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("cbStruct", typeof(System.Runtime.InteropServices.ComTypes.BIND_OPTS).GetField("cbStruct")!),
new("dwTickCountDeadline", typeof(System.Runtime.InteropServices.ComTypes.BIND_OPTS).GetField("dwTickCountDeadline")!),
new("grfFlags", typeof(System.Runtime.InteropServices.ComTypes.BIND_OPTS).GetField("grfFlags")!),
new("grfMode", typeof(System.Runtime.InteropServices.ComTypes.BIND_OPTS).GetField("grfMode")!)
    });
}