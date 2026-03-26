using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xunit;
using static Serde.Test.GeneratorTestUtils;

namespace Serde.Test
{
    public class FieldInitializerTests
    {
        [Fact]
        public Task FieldInitializers()
        {
            var src = """
using Serde;
[GenerateDeserialize]
partial class C
{
    // Compile-time constants
    public string Str = "hello";
    public int Num = 42;
    public bool Flag = true;
    public string? Nullable = null;
    public double Dbl = 3.14;
    public char Ch = 'x';

    // Static member access
    public string FromMethod = string.Empty;
    public int MaxInt = int.MaxValue;
}
""";
            return VerifyDeserialize(src);
        }

        /// <summary>
        /// Enum field initializers should be preserved as compile-time constants.
        /// </summary>
        [Fact]
        public Task FieldInitializerEnum()
        {
            var src = """
using Serde;

[GenerateDeserialize]
enum Color { Red, Green, Blue }

[GenerateDeserialize]
partial class C
{
    public Color Color = Color.Green;
}
""";
            return VerifyDeserialize(src);
        }

        /// <summary>
        /// Arithmetic/complex expressions in initializers should NOT be preserved
        /// (not compile-time constants from GetConstantValue's perspective when involving
        /// non-literal sub-expressions), falling back to default!.
        /// </summary>
        [Fact]
        public Task FieldInitializerUnsafe()
        {
            var src = """
using Serde;
using System.Collections.Generic;

[GenerateDeserialize]
partial class C
{
    // new expressions are not constants or static member accesses
    public List<int> Items = new List<int>();
    // Array creation is not a constant
    public int[] Arr = new int[10];
    // nameof references a symbol that may not be in scope in generated code
    public string Name = nameof(C);
}
""";
            return VerifyDeserialize(src);
        }

        /// <summary>
        /// Verify that null! on a non-nullable reference type roundtrips correctly.
        /// GetConstantValue returns null (without the !), so we need to re-add the
        /// null-forgiving operator for the generated code to compile under #nullable enable.
        /// </summary>
        [Fact]
        public Task FieldInitializerNullForgiving()
        {
            var src = """
using Serde;

[GenerateDeserialize]
partial class C
{
    // null! on non-nullable types — must roundtrip as null!
    public string S = null!;
    public int[] Arr = null!;
    // null on nullable type — no ! needed
    public string? N = null;
}
""";
            return VerifyDeserialize(src);
        }

        /// <summary>
        /// Primary constructor parameters referenced in field initializers must NOT be
        /// preserved. This was the root cause of https://github.com/serdedotnet/serde/issues/313.
        /// We use a record here so the primary ctor params are proper public properties
        /// (avoiding the pre-existing #313 generator crash for classes with mismatched
        /// ctor param / field names).
        /// The field `Extra = X + 1` references ctor param `X`, so GetConstantValue
        /// won't succeed and it falls back to default!.
        /// </summary>
        [Fact]
        public Task FieldInitializerPrimaryCtorParam()
        {
            var src = """
using Serde;

[GenerateDeserialize]
partial record C(int X)
{
    // References primary ctor parameter — must fall back to default!
    public int Extra = X + 1;
    // Safe constant — should be preserved
    public int Z = 100;
}
""";
            return VerifyDeserialize(src);
        }

        private static Task VerifyDeserialize(
            string src,
            [CallerMemberName] string caller = "")
            => VerifyGeneratedCode(src,
                nameof(FieldInitializerTests),
                caller,
                multiFile: false);
    }
}
