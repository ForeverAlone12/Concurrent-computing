using System.Reflection;

namespace Lab1;

public class Command
{
    protected Dictionary<String, MethodInfo> Dictionary { get; }

    public Command()
    {
        Dictionary = new Dictionary<string, MethodInfo>();
    }
}