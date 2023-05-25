
using System;

namespace Serde;

readonly record struct FlattenSerializer(ISerializeType SerializeType) : ISerializer
{
    readonly record struct FlattenSerializeType(ISerializeType Ty) : ISerializeType
    {
        public void SerializeField<V>(ReadOnlySpan<byte> name, V value) where V : ISerialize
        {
            Ty.SerializeField(name, value);
        }
        public void End() { }
    }
    ISerializeType ISerializer.SerializeType(string name, int numFields) => new FlattenSerializeType(SerializeType);

    private static readonly Exception NotType = new InvalidOperationException("Flattening can only be used with fields of a custom type");

    void ISerializer.SerializeBool(bool b) => throw NotType;
    void ISerializer.SerializeByte(byte b) => throw NotType;
    void ISerializer.SerializeChar(char c) => throw NotType;
    void ISerializer.SerializeDecimal(decimal d) => throw NotType;
    ISerializeDictionary ISerializer.SerializeDictionary(int? length) => throw NotType;
    void ISerializer.SerializeDouble(double d) => throw NotType;
    ISerializeEnumerable ISerializer.SerializeEnumerable(string typeName, int? length) => throw NotType;
    void ISerializer.SerializeEnumValue<T1>(string enumName, string? valueName, T1 value) => throw NotType;
    void ISerializer.SerializeFloat(float f) => throw NotType;
    void ISerializer.SerializeI16(short i16) => throw NotType;
    void ISerializer.SerializeI32(int i32) => throw NotType;
    void ISerializer.SerializeI64(long i64) => throw NotType;
    void ISerializer.SerializeNotNull<T1>(T1 t) => throw NotType;
    void ISerializer.SerializeNull() => throw NotType;
    void ISerializer.SerializeSByte(sbyte b) => throw NotType;
    void ISerializer.SerializeString(string s) => throw NotType;

    void ISerializer.SerializeU16(ushort u16) => throw NotType;

    void ISerializer.SerializeU32(uint u32) => throw NotType;

    void ISerializer.SerializeU64(ulong u64) => throw NotType;
}