
#nullable enable
using System;
using Serde;

namespace Serde.Test
{
    partial class XmlTests
    {
        partial struct BoolStruct : Serde.ISerialize
        {
            void Serde.ISerialize.Serialize(ISerializer serializer)
            {
                var type = serializer.SerializeType<Serde.Test.XmlTests.BoolStruct>("BoolStruct", 1);
                type.SerializeField("BoolField", new BoolWrap(this.BoolField));
                type.End();
            }
        }
    }
}