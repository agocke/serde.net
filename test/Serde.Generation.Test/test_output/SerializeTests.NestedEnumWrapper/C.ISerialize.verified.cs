//HintName: C.ISerialize.cs

#nullable enable
using System;
using Serde;

partial class C : Serde.ISerialize
{
    void Serde.ISerialize.Serialize(ISerializer serializer)
    {
        var type = serializer.SerializeType("C", 1);
        type.SerializeFieldIfNotNull("colorOpt", new NullableWrap.SerializeImpl<Rgb, global::RgbWrap>(this.ColorOpt), this.ColorOpt);
        type.End();
    }
}