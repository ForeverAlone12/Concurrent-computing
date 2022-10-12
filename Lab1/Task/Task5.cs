namespace Lab1.Task;

public class Task5 : AbstractTask
{
    public Task5() : base("Task5")
    {
    }

    protected override void ExecutionWithoutThread()
    {
        base.ExecutionWithoutThread();

        TimeExecution.Start();
        Array.Max();
        TimeExecution.Stop();
        WriteTimeResult();
    }
}