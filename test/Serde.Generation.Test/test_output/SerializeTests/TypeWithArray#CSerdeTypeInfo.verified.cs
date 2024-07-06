﻿//HintName: CSerdeTypeInfo.cs
internal static class CSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "C",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("intArr", typeof(C).GetField("IntArr")!)
    });
}