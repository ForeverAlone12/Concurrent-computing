namespace Lab1.Task;

public class Task6 : AbstractTask
{
    public Task6() : base("Task6")
    {
    }

    protected override void ExecutionWithoutThread()
    {
        base.ExecutionWithoutThread();

        TimeExecution.Start();
        Array.Min();
        TimeExecution.Stop();
        WriteTimeResult();
    }
}