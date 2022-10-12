namespace Lab1.Task;

public class Task4 : AbstractTask
{
    public Task4() : base("Task4")
    {
    }

    protected override void ExecutionWithoutThread()
    {
        base.ExecutionWithoutThread();

        TimeExecution.Start();
        Array.Aggregate((x, y) => x * y);
        TimeExecution.Stop();
        WriteTimeResult();
    }
}