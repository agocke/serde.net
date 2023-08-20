//HintName: Test.Parent.ISerialize.cs

#nullable enable
using System;
using Serde;

namespace Test
{
    partial record Parent : Serde.ISerialize
    {
        void Serde.ISerialize.Serialize(ISerializer serializer)
        {
            var type = serializer.SerializeType<Test.Parent>("Parent", 1);
            type.SerializeField("r", new RecursiveWrap(this.R));
            type.End();
        }
    }
}