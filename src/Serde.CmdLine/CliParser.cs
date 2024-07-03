
namespace Serde.CmdLine;

partial class CliParser
{
    public static T Parse<T>(string[] args) where T : IDeserialize<T>
    {
        var parser = new CliParser(args);
        return T.Deserialize(parser);
    }
}
