namespace Lab1.Task;

public class Task5 : AbstractTask
{
    protected override void ExecutionWithoutThread()
    {
        base.ExecutionWithoutThread();
        
        TimeExecution.Start();
        Array.Max();
        TimeExecution.Stop();
        WriteTimeResult();
    }
}