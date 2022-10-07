namespace Lab1.Task;

public class Task3: AbstractTask
{

    private int _number;
    
    protected override void ReadInputData()
    {
        base.ReadInputData();
        
        _number = ReadDigitFromConsole("Введите число: ");
    }

    protected override void ExecutionWithoutThread()
    {
        base.ExecutionWithoutThread();
        
        Logger.Debug("Вычисление стандартными стредствами.");
        TimeExecution.Start();
        Array.Count(element => element == _number);
        TimeExecution.Stop();
        WriteTimeResult();

        int count = 0;
        Logger.Debug("Вычисление вручную.");
        TimeExecution.Start();
        for (var i = 0; i < CountElements; i++)
        {
            if (Array[i] == _number)
            {
                count++;
            }
        }
        TimeExecution.Stop();
        WriteTimeResult();
    }
    
    protected override void ExecutionWithThread()
    {
        base.ExecutionWithThread();

        var count = CountElements / CountThreads;
        
        foreach (var thread in Threads)
        {
            // thread.Start(() => { GetSum();});
        }
        
        TimeExecution.Start();
        TimeExecution.Stop();
        WriteTimeResult();
    }
}