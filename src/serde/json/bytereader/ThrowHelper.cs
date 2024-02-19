
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Serde.Json;

internal static class DeserializerThrowHelper
{
    [DoesNotReturn]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ThrowUnexpectedEof()
    {
        throw new InvalidDeserializeValueException("Unexpected end of stream");
    }
}