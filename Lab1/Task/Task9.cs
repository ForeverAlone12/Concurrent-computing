namespace Lab1.Task;

public class Task9 : AbstractTask
{
    public Task9() : base("Task9",
        "Вычисдление суммы последовательности с чередованием знака.")
    {
    }

    protected override void ExecutionWithoutThread()
    {
        base.ExecutionWithoutThread();

        int znak = 1;
        TimeExecution.Start();
        TaskResult.Results = Array.Aggregate((x, y) => x + y * (znak *= -1)).ToString();
        TimeExecution.Stop();
        WriteTimeResult();
    }
}