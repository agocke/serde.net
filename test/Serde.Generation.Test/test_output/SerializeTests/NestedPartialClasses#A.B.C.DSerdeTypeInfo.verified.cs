﻿//HintName: A.B.C.DSerdeTypeInfo.cs
partial class A
{
    partial class B
{
    partial class C
{
    internal static class DSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "D",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("field", typeof(A.B.C.D).GetField("Field")!)
    });
}
}
}
}