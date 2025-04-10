
using System.Collections.Generic;

namespace Serde.Json;

partial class JsonSerializer
{
    public static string Serialize<T>(List<T> s)
        where T : ISerializeProvider<T>
        => Serialize<List<T>, ListProxy.Ser<T, T>>(s);

    public static string Serialize(List<string> s)
    {
        return Serialize<List<string>, ListProxy.Ser<string, StringProxy>>(s);
    }
}
