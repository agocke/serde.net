﻿namespace Serde.Test;
partial class GenericWrapperTests
{
    internal static class CustomArrayWrapExplicitOnTypeSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "CustomArrayWrapExplicitOnType",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("a", typeof(Serde.Test.GenericWrapperTests.CustomArrayWrapExplicitOnType).GetField("A")!)
    });
}
}