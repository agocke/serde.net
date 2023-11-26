//HintName: OPTSWrap.ISerialize.cs

#nullable enable
using System;
using Serde;

partial record struct OPTSWrap : Serde.ISerialize
{
    void Serde.ISerialize.Serialize(ISerializer serializer)
    {
        var type = serializer.SerializeType("BIND_OPTS", 4);
        type.SerializeField("cbStruct", new Int32Wrap(Value.cbStruct));
        type.SerializeField("dwTickCountDeadline", new Int32Wrap(Value.dwTickCountDeadline));
        type.SerializeField("grfFlags", new Int32Wrap(Value.grfFlags));
        type.SerializeField("grfMode", new Int32Wrap(Value.grfMode));
        type.End();
    }
}