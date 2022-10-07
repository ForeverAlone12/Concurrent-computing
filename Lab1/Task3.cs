namespace Lab1;

public class Task3: AbstractTask
{

    private int _number;
    
    public Task3() : base()
    {
        ExecutionWithoutThread();
        ExecutionWithThread();
    }
    
    protected override void ReadInputData()
    {
        base.ReadInputData();
        _number = ReadIntFromConsole("Введите число: ");
    }

    public void ExecutionWithoutThread()
    {
        base.ExecutionWithoutThread();
        
        TimeExecution.Start();
        int count = Array.Count(element => element == _number);
        TimeExecution.Stop();
        Logger.Info($"Время сравнения массивов: {TimeExecution.ElapsedMilliseconds} ms");
    }
}