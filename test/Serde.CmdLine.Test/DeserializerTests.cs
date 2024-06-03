using System.ComponentModel;
using Serde;
using Xunit;

namespace Serde.CmdLine.Test;

public sealed partial class DeserializerTests
{
    [Fact]
    public void SpectreExample()
    {
        string[] testArgs = [ "-p", "*.txt", "--hidden", ];
        var cmd = CmdLine.Parse<FileSizeCommand>(testArgs);
        Assert.Equal(new FileSizeCommand { SearchPath = null, SearchPattern = "*.txt", IncludeHidden = true }, cmd);
    }

    [Fact]
    public void TestSearchPath()
    {
        string[] testArgs = [ "search-path" ];
        var cmd = CmdLine.Parse<FileSizeCommand>(testArgs);
        Assert.Equal(new FileSizeCommand { SearchPath = "search-path", SearchPattern = null, IncludeHidden = null }, cmd);
    }

    [GenerateDeserialize]
    internal sealed partial record FileSizeCommand
    {
        [Description("Path to search. Defaults to current directory.")]
        [CommandParameter(0, "[searchPath]")]
        public string? SearchPath { get; init; }

        [CommandOption("-p|--pattern")]
        public string? SearchPattern { get; init; }

        [CommandOption("--hidden")]
        public bool? IncludeHidden { get; init; }
    }
}
