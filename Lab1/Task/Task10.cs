namespace Lab1.Task;

public class Task10 : AbstractTask
{
    public Task10() : base("Task10", 
        "Вычисление суммы чётных элементов последовательности")
    {
    }
    
    protected override void ExecutionWithoutThread()
    {
        base.ExecutionWithoutThread();

        int summa = 0;
        TimeExecution.Start();
        foreach (var element in Array)
        {
            if (element % 2 == 0)
                summa += element;
        }
        TimeExecution.Stop();
        TaskResult.Results = summa.ToString();
        WriteTimeResult();
    }
}