using System.Diagnostics;

namespace Lab1;

public class Task1: AbstractTask
{
    /// <summary>
    /// Количество потоков.
    /// </summary>
    private int _countThreads;

    /// <summary>
    /// Минимальное количество потоков.
    /// </summary>
    private const int MinCountThread = 100;
    
    /// <summary>
    /// Максимальное количество потоков.
    /// </summary>
    private const int MaxCountThread = 10000;

    private int[] _arrayA;
    private int[] _arrayC;

    public Task1()
        : base()
    {
        _arrayA = new int[CountElements];
        _arrayC = new int[CountElements];
        InitializationArray();
        ExecutionWithoutThread();
        ExecutionWithThread();
    }
    
    protected override void ReadInputData()
    {
        base.ReadInputData();
       _countThreads = ReadIntFromConsole("Введите количество потоков: ", MinCountThread, MaxCountThread);
    }

    /// <summary>
    /// Инициализация массивов случайными числами.
    /// </summary>
    private void InitializationArray()
    {
        Random random;
        for (var i = 0; i < CountElements; i++)
        {
            random = new Random();
            _arrayA[i] = random.Next();
            _arrayC[i] = random.Next();
        }
    }

    public void ExecutionWithThread()
    {
        base.ExecutionWithThread();
        
        TimeExecution.Start();
        for (var i = 0; i < _countThreads; i++)
        {
            
        }
        
        TimeExecution.Stop();
        Logger.Info($"Время сравнения массивов: {TimeExecution.ElapsedMilliseconds} ms");
    }

    public void ExecutionWithoutThread()
    {
        base.ExecutionWithoutThread();

        int countNotEqualElements = 0;
        TimeExecution.Start();
        for (var i = 0; i < CountElements; i++)
        {
            if (_arrayA[i] != _arrayC[i])
            {
                countNotEqualElements++;
            }
        }
        TimeExecution.Stop();
        Logger.Info($"Время сравнения массивов: {TimeExecution.ElapsedMilliseconds} ms");
    }
}