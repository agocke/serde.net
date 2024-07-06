//HintName: Test.ChannelSerdeTypeInfo.cs
namespace Test;
internal static class ChannelSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "Channel",
        Serde.TypeInfo.TypeKind.Enum,
        new Serde.TypeInfo.FieldInfo[] {
new("a", typeof(Test.Channel).GetField("A")!),
new("b", typeof(Test.Channel).GetField("B")!),
new("c", typeof(Test.Channel).GetField("C")!)
    });
}