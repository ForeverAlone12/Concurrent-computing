namespace Lab1;

public abstract class AbstractTask : ITask
{
    protected string Title { get; init; }

    public AbstractTask(string title)
    {
        Title = title;
        ReadInputData();
    }
    protected virtual void ReadInputData()
    {
        Console.WriteLine("Считывание входных параметров");
    }

    public void ExecutionWithThread()
    {
        Console.WriteLine("Выполнение в многопоточном режиме");
    }

    public void ExecutionWithoutThread()
    {
        Console.WriteLine("Выполнение в однопоточном режиме");
    }
}