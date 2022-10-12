namespace Lab1.Task;

public class Task6 : AbstractTask
{
    protected override void ExecutionWithoutThread()
    {
        base.ExecutionWithoutThread();
        
        TimeExecution.Start();
        Array.Min();
        TimeExecution.Stop();
        WriteTimeResult();
    }
}