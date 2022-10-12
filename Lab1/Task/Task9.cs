namespace Lab1.Task;

public class Task9 : AbstractTask
{
    protected override void ExecutionWithoutThread()
    {
        base.ExecutionWithoutThread();

        int summa = 0;
        TimeExecution.Start();
        for (var i = 2; i < Array.Length; i += 2)
        {
            summa += Array[i];
        }
        TimeExecution.Stop();
        WriteTimeResult();
    }
}