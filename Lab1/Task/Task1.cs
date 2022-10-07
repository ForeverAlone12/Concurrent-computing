using System.Diagnostics;

namespace Lab1.Task;

public class Task1: AbstractTask
{
    private int[] _arrayC;

    public Task1()
        : base()
    {
        _arrayC = new int[CountElements];
        _arrayC = InitialArrayRandomData();
    }
    

    protected override void ExecutionWithThread()
    {
        base.ExecutionWithThread();
        
        TimeExecution.Start();
        for (var i = 0; i < CountThreads; i++)
        {
            
        }
        
        TimeExecution.Stop();
        Logger.Info($"Время сравнения массивов: {TimeExecution.ElapsedMilliseconds} ms");
    }

    protected override void ExecutionWithoutThread()
    {
        base.ExecutionWithoutThread();

        int countNotEqualElements = 0;
        TimeExecution.Start();
        
        
        for (var i = 0; i < CountElements; i++)
        {
            if (Array[i] != _arrayC[i])
            {
                countNotEqualElements++;
            }
        }
        TimeExecution.Stop();
        Logger.Info($"Время сравнения массивов: {TimeExecution.ElapsedMilliseconds} ms");
    }
}