﻿//HintName: S2SerdeTypeInfo.cs
internal static class S2SerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(new (string, System.Reflection.MemberInfo)[] {
("E", typeof(S2).GetField("E")!)
    });
}