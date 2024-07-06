namespace Serde.Test;
partial class GenericWrapperTests
{
    internal static class CustomImArrayExplicitWrapOnMemberSerdeTypeInfo
{
    internal static readonly Serde.TypeInfo TypeInfo = Serde.TypeInfo.Create(
        "CustomImArrayExplicitWrapOnMember",
        Serde.TypeInfo.TypeKind.CustomType,
        new Serde.TypeInfo.FieldInfo[] {
new("a", typeof(Serde.Test.GenericWrapperTests.CustomImArrayExplicitWrapOnMember).GetField("A")!)
    });
}
}