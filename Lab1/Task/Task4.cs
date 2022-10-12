namespace Lab1.Task;

public class Task4 : AbstractTask
{
    public Task4() : base(
        "Task4",
        "Вычисление произведения последовательности чисел")
    {
    }

    protected override void ExecutionWithoutThread()
    {
        base.ExecutionWithoutThread();

        TimeExecution.Start();
        TaskResult.Results = Array.Aggregate((x, y) => x * y).ToString();
        TimeExecution.Stop();
        WriteTimeResult();
    }
}