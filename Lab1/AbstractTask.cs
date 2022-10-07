using System.Diagnostics;
using NLog;

namespace Lab1;

public abstract class AbstractTask
{
    /// <summary>
    ///Данные о времени запуске программы.
    /// </summary>
    protected Stopwatch TimeExecution { get; }

    /// <summary>
    /// Количество элементов массивов.
    /// </summary>
    protected int CountElements;
    
    /// <summary>
    /// Минимальное количество элеметов массива.
    /// </summary>
    protected const int MinCountElements = 10000;
    
    /// <summary>
    /// Максимальное количество элеметов массива.
    /// </summary>
    protected const int MaxCountElements = 100000;

    
    protected int[] Array;

    /// <summary>
    /// Логгер приложения.
    /// <include file="nlog.config" path="nlog/[@name="nlog"]/*"/>
    /// </summary>
    protected Logger Logger { get; }

    protected AbstractTask()
    {
        Logger = LogManager.GetCurrentClassLogger();
        TimeExecution = new Stopwatch();
        ReadInputData();
        Array = new int[CountElements];
        Array = CreateArrayRandomData();
    }
    
    /// <summary>
    /// Считывание входных данных.
    /// </summary>
    protected virtual void ReadInputData()
    {
        Logger.Debug("Считывание входных параметров.");
        CountElements = ReadIntFromConsole("Введите количество элементов: ", MinCountElements, MaxCountElements);
    }

    protected int[] CreateArrayRandomData()
    {
        var array = new int[CountElements];
        Random random;
        for (var i = 0; i < CountElements; i++)
        {
            random = new Random();
            array[i] = random.Next();
        }

        return array;
    }
    protected int[] CreateArrayRandomData(int countElements)
    {
        var array = new int[countElements];
        Random random;
        for (var i = 0; i < countElements; i++)
        {
            random = new Random();
            array[i] = random.Next();
        }

        return array;
    }

    /// <summary>
    /// Выполнение действий в многопоточном режиме.
    /// </summary>
    public void ExecutionWithThread()
    {
        Logger.Debug("Выполнение в многопоточном режиме.");
    }

    /// <summary>
    /// Выполнение действий в однопоточном потоке.
    /// </summary>
    public void ExecutionWithoutThread()
    {
        Logger.Debug("Выполнение в однопоточном режиме.");
    }

    /// <summary>
    /// Считывание целового числа из консоли.
    /// </summary>
    /// <param name="message">Сообщение перед вводом данных</param>
    /// <param name="minValue">Минимальное значение (включительно).</param>
    /// <param name="maxValue">Максимальное значение (включительно).</param>
    /// <returns>Считанное целое число с консоли.</returns>
    public int ReadIntFromConsole(string message, int minValue, int maxValue)
    {
        bool error = true;
        int resultRead = 0;
        do
        {
            try
            {
                Logger.Info(message);
                resultRead = Convert.ToInt32(Console.ReadLine());
                
                error = (resultRead < minValue || resultRead > maxValue);

                if (error)
                {
                    WriteError($"Вводимое значение должно быть в промежутке [{minValue}; {maxValue}]");
                }
            }
            catch (FormatException formatException)
            {
                WriteError(formatException.ToString());
            }
        } while (error);

        return resultRead;
    }
    
    /// <summary>
    /// Считывание целового числа из консоли.
    /// </summary>
    /// <param name="message">Сообщение перед вводом данных</param>
    /// <returns>Считанное целое число с консоли.</returns>
    public int ReadIntFromConsole(string message)
    {
        bool error = true;
        int resultRead = 0;
        do
        {
            try
            {
                Logger.Info(message);
                resultRead = Convert.ToInt32(Console.ReadLine());
                error = false;
            }
            catch (FormatException formatException)
            {
                WriteError(formatException.ToString());
            }
        } while (error);

        return resultRead;
    }

    /// <summary>
    /// Запись ошибки.
    /// </summary>
    /// <param name="error">Ошибка.</param>
    public void WriteError(string error)
    {
        Logger.Error(error);
    }
}

