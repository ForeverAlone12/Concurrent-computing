namespace Lab1.Task;

public class Task5 : AbstractTask
{
    public Task5() : base("Task5",
        "Поиск максимального значения последовательности")
    {
    }

    protected override void ExecutionWithoutThread()
    {
        base.ExecutionWithoutThread();

        TimeExecution.Start();
        TaskResult.Results = Array.Max().ToString();
        TimeExecution.Stop();
        WriteTimeResult();
    }
}