
namespace Serde.CmdLine;

public sealed class CommandArgument : Attribute
{
}

public sealed class CommandOption : Attribute
{
    public CommandOption(string flagNames)
    {
        FlagNames = flagNames;
    }

    public string FlagNames { get; }
}