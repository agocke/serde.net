//HintName: Serde.Test.AllInOneSerdeTypeInfo.cs
namespace Serde.Test;
internal static class AllInOneSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "AllInOne",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("boolField", typeof(Serde.Test.AllInOne).GetField("BoolField")!),
new("charField", typeof(Serde.Test.AllInOne).GetField("CharField")!),
new("byteField", typeof(Serde.Test.AllInOne).GetField("ByteField")!),
new("uShortField", typeof(Serde.Test.AllInOne).GetField("UShortField")!),
new("uIntField", typeof(Serde.Test.AllInOne).GetField("UIntField")!),
new("uLongField", typeof(Serde.Test.AllInOne).GetField("ULongField")!),
new("sByteField", typeof(Serde.Test.AllInOne).GetField("SByteField")!),
new("shortField", typeof(Serde.Test.AllInOne).GetField("ShortField")!),
new("intField", typeof(Serde.Test.AllInOne).GetField("IntField")!),
new("longField", typeof(Serde.Test.AllInOne).GetField("LongField")!),
new("stringField", typeof(Serde.Test.AllInOne).GetField("StringField")!),
new("nullStringField", typeof(Serde.Test.AllInOne).GetField("NullStringField")!),
new("uIntArr", typeof(Serde.Test.AllInOne).GetField("UIntArr")!),
new("nestedArr", typeof(Serde.Test.AllInOne).GetField("NestedArr")!),
new("intImm", typeof(Serde.Test.AllInOne).GetField("IntImm")!),
new("color", typeof(Serde.Test.AllInOne).GetField("Color")!)
    });
}