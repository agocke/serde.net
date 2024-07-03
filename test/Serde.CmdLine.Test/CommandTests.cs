﻿namespace Serde.CmdLine.Test;

public sealed partial class CommandTests
{
    [Fact]
    public void BasicCommandTest()
    {
        string[] cmdLine = [ "-f", "abc" ];
        var cmd = CliParser.Parse<BasicCommand>(cmdLine);
        Assert.Equal(new BasicCommand
        {
            FlagOption = true,
            Arg = "abc"
        }, cmd);
    }

    [GenerateSerde]
    private sealed partial record BasicCommand
    {
        [CommandOption("-f|--flag-option")]
        public bool FlagOption { get; init; }

        [CommandArgument]
        public required string Arg { get; init; }
    }
}
