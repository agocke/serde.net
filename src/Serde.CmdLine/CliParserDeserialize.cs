
using System.Text;
using Microsoft.VisualBasic;

namespace Serde.CmdLine;

public sealed partial class CliParser : IDeserializer
{
    private readonly string[] _args;
    private int _currentArgIndex = 0;

    private bool _parsingFlag = false;

    private CliParser(string[] args)
    {
        _args = args;
    }

    T IDeserializer.DeserializeAny<T>(IDeserializeVisitor<T> v)
    {
        throw new NotImplementedException();
    }

    T IDeserializer.DeserializeBool<T>(IDeserializeVisitor<T> v)
    {
        // Bool flags are tricky because sometimes the arg is implicit. We'll try to parse
        // the current argument as a bool. If that doesn't work, and the current type info
        // is a CommandOption, we'll assume this is a true flag and don't increment the arg index.
        var currentArg = _args[_currentArgIndex];
        if (bool.TryParse(currentArg, out bool result))
        {
            _currentArgIndex++;
            return v.VisitBool(result);
        }
        if (_parsingFlag)
        {
            return v.VisitBool(true);
        }

        throw new InvalidDeserializeValueException($"Expected bool value, got '{currentArg}'");
    }

    T IDeserializer.DeserializeByte<T>(IDeserializeVisitor<T> v)
    {
        throw new NotImplementedException();
    }

    T IDeserializer.DeserializeChar<T>(IDeserializeVisitor<T> v)
    {
        throw new NotImplementedException();
    }

    IDeserializeCollection IDeserializer.DeserializeCollection(TypeInfo typeInfo)
    {
        throw new NotImplementedException();
    }

    T IDeserializer.DeserializeDecimal<T>(IDeserializeVisitor<T> v)
    {
        throw new NotImplementedException();
    }

    T IDeserializer.DeserializeDouble<T>(IDeserializeVisitor<T> v)
    {
        throw new NotImplementedException();
    }

    T IDeserializer.DeserializeFloat<T>(IDeserializeVisitor<T> v)
    {
        throw new NotImplementedException();
    }

    T IDeserializer.DeserializeI16<T>(IDeserializeVisitor<T> v)
    {
        throw new NotImplementedException();
    }

    T IDeserializer.DeserializeI32<T>(IDeserializeVisitor<T> v)
    {
        throw new NotImplementedException();
    }

    T IDeserializer.DeserializeI64<T>(IDeserializeVisitor<T> v)
    {
        throw new NotImplementedException();
    }

    T IDeserializer.DeserializeIdentifier<T>(IDeserializeVisitor<T> v)
    {
        throw new NotImplementedException();
    }

    T IDeserializer.DeserializeNullableRef<T>(IDeserializeVisitor<T> v)
    {
        throw new NotImplementedException();
    }

    T IDeserializer.DeserializeSByte<T>(IDeserializeVisitor<T> v)
    {
        throw new NotImplementedException();
    }

    T IDeserializer.DeserializeString<T>(IDeserializeVisitor<T> v)
    {
        return v.VisitString(_args[_currentArgIndex++]);
    }

    IDeserializeType IDeserializer.DeserializeType(TypeInfo typeInfo)
    {
        return this;
    }

    T IDeserializer.DeserializeU16<T>(IDeserializeVisitor<T> v)
    {
        throw new NotImplementedException();
    }

    T IDeserializer.DeserializeU32<T>(IDeserializeVisitor<T> v)
    {
        throw new NotImplementedException();
    }

    T IDeserializer.DeserializeU64<T>(IDeserializeVisitor<T> v)
    {
        throw new NotImplementedException();
    }
}

partial class CliParser : IDeserializeType
{
    V IDeserializeType.ReadValue<V, D>(int index)
    {
        var val = D.Deserialize(this);
        _parsingFlag = false;
        return val;
    }

    int IDeserializeType.TryReadIndex(TypeInfo map, out string? errorName)
    {
        if (_currentArgIndex >= _args.Length)
        {
            errorName = null;
            return IDeserializeType.EndOfType;
        }

        var arg = _args[_currentArgIndex];
        // loop through all the properties to find a match
        for (int i = 0; i < map.FieldCount; i++)
        {
            var attrs = map.GetCustomAttributeData(i);
            foreach (var attr in attrs)
            {
                if (attr is {
                    AttributeType: { Name: nameof(CommandOption) },
                    ConstructorArguments: [{ Value: string flagNames }] })
                {
                    var shortAndLong = flagNames.Split('|');
                    foreach (var flagValue in shortAndLong)
                    {
                        if (arg == flagValue)
                        {
                            errorName = null;
                            _parsingFlag = true;
                            _currentArgIndex++;
                            return i;
                        }
                    }
                }
                else if (attr is {
                    AttributeType: { Name: nameof(CommandArgument) }})
                {
                    if (!arg.StartsWith('-'))
                    {
                        errorName = null;
                        return i;
                    }
                }
            }
        }
        errorName = arg;
        return IDeserializeType.IndexNotFound;
    }
}