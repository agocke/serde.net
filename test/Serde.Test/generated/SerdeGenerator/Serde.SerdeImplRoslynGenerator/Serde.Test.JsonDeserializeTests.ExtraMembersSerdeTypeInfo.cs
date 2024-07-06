﻿namespace Serde.Test;
partial class JsonDeserializeTests
{
    internal static class ExtraMembersSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "ExtraMembers",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("b", typeof(Serde.Test.JsonDeserializeTests.ExtraMembers).GetField("b")!)
    });
}
}