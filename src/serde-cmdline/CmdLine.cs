using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace Serde.CmdLine;

public static class CmdLine
{
    public static T Parse<T>(string[] args)
        where T : IDeserialize<T>
    {
        return T.Deserialize(new Deserializer(args));
    }
}