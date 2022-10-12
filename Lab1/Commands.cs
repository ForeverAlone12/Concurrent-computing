using Lab1.Task;

namespace Lab1;

public class Commands
{
    private readonly Dictionary<String, ITask> _dictionaryTask;

    public Commands()
    {
        _dictionaryTask = new Dictionary<string, ITask>
        {
            { "1", new Task1() },
            { "3", new Task3() }
        };
    }

    public bool ParseCommand(string command)
    {
        if (_dictionaryTask.ContainsKey(command))
        {
            _dictionaryTask[command].Run();
        }

        return true;
    }
}