
#nullable enable
using System;
using Serde;

namespace Serde.Test
{
    partial class JsonSerializerTests
    {
        partial struct FlattenNested : Serde.ISerialize
        {
            void Serde.ISerialize.Serialize(ISerializer serializer)
            {
                var type = serializer.SerializeType("FlattenNested", 1);
                type.SerializeField("x"u8, new Int32Wrap(this.X));
                type.End();
            }
        }
    }
}