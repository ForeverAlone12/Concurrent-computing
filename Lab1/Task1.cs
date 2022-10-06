using System.Diagnostics;

namespace Lab1;

public class Task1: AbstractTask
{
    /// <summary>
    /// Количество элементов массивов.
    /// </summary>
    private int _countElements;

    private int[] _arrayA;
    private int[] _arrayC;

    public Task1() : base("asda")
    {
        Console.WriteLine(Title);
        _arrayA = new int[_countElements];
        _arrayC = new int[_countElements];
        InitializationArray();
    }
    

    /// <summary>
    /// Считывание входных данных.
    /// </summary>
    protected override void ReadInputData()
    {
        base.ReadInputData();
        bool error = true;
        do
        {
            try
            {
                Console.Write("Введите количество элементов: ");
                _countElements = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Вы ввели: {_countElements}");


                error = false;
            }
            catch (FormatException formatException)
            {
                Console.WriteLine($"Ошибка ввода: {formatException} ");
            }
    
        } while (error);
    }

    /// <summary>
    /// Инициализация массивов случайными числами.
    /// </summary>
    private void InitializationArray()
    {
        Random random;
        for (var i = 0; i < _countElements; i++)
        {
            random = new Random();
            _arrayA[i] = random.Next();
            _arrayC[i] = random.Next();
        }
    }


    public void ExecutionWithThread()
    {
        base.ExecutionWithThread();
    }

    public void ExecutionWithoutThread()
    {
        base.ExecutionWithoutThread();
        var timeExecution = new Stopwatch();

        int countNotEqualElements = 0;
        timeExecution.Start();
        for (var i = 0; i < _countElements; i++)
        {
            if (_arrayA[i] != _arrayC[i])
            {
                countNotEqualElements++;
            }
        }
        timeExecution.Stop();
        Console.WriteLine($"Время сравнения массивов: {timeExecution.ElapsedMilliseconds} ms");
    }
}