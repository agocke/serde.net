﻿//HintName: S2SerdeTypeInfo.cs
internal static class S2SerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "S2",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("E", typeof(S2).GetField("E")!)
    });
}