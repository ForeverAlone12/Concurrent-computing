namespace Lab1.Task;

public class Task7 : AbstractTask
{
    private List<int> _primeNumbers;
    public Task7() : base("Task7",
        "Нахождение в последовательности всех простых чисел")
    {
        _primeNumbers = new List<int>();
    }

    protected override void ExecutionWithoutThread()
    {
        base.ExecutionWithoutThread();

        TimeExecution.Start();
        foreach (var element in Array)
        {
            if (IsPrimeNumber(element))
                _primeNumbers.Add(element);
        }
        TimeExecution.Stop();
        TaskResult.Results = _primeNumbers.Count.ToString();
        WriteTimeResult();
    }

    private bool IsPrimeNumber(int number)
    {
        for (var i = 2; i < number; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}