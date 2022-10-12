namespace Lab1.Task;

public class Task6 : AbstractTask
{
    public Task6() : base("Task6",
        "Поиск минимального значения последовательности")
    {
    }

    protected override void ExecutionWithoutThread()
    {
        base.ExecutionWithoutThread();

        TimeExecution.Start();
        TaskResult.Results = Array.Min().ToString();
        TimeExecution.Stop();
        WriteTimeResult();
    }
}