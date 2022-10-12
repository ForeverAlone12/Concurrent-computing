using System.Diagnostics;
using NLog;

namespace Lab1.Task;

public abstract class AbstractTask : ITask
{
    /// <summary>
    ///Данные о времени запуске программы.
    /// </summary>
    protected Stopwatch TimeExecution;

    /// <summary>
    /// Количество элементов массивов.
    /// </summary>
    protected int CountElements;

    /// <summary>
    /// Минимальное количество элеметов массива.
    /// </summary>
    private const int MinCountElements = 10000;

    /// <summary>
    /// Максимальное количество элеметов массива.
    /// </summary>
    private const int MaxCountElements = 320000000;

    /// <summary>
    /// Количество потоков.
    /// </summary>
    protected int CountThreads;

    /// <summary>
    /// Минимальное количество потоков.
    /// </summary>
    private const int MinCountThread = 100;

    /// <summary>
    /// Максимальное количество потоков.
    /// </summary>
    private const int MaxCountThread = 10000;

    /// <summary>
    /// Последовательность натуральных чисел.
    /// </summary>
    protected int[] Array;

    protected Thread[] Threads;

    /// <summary>
    /// Логгер приложения.
    /// <include file="nlog.config" path="nlog/[@name="nlog"]/*"/>
    /// </summary>
    protected Logger Logger { get; }

    /// <summary>
    /// Формат вывода целого числа.
    /// </summary>
    private const string IntFormat = "{0:## ##0}";

    protected AbstractTask()
    {
        Logger = LogManager.GetCurrentClassLogger();
        TimeExecution = new Stopwatch();
    }

    /// <summary>
    /// Считывание входных данных.
    /// </summary>
    protected virtual void ReadInputData()
    {
        Logger.Debug("Считывание входных параметров.");
        CountElements = ReadDigitFromConsole(
            $"Введите количество элементов [{FormatInt(MinCountElements)}; {FormatInt(MaxCountElements)}]: ",
            MinCountElements, MaxCountElements);
        CountThreads = ReadDigitFromConsole(
            $"Введите количество потоков [{FormatInt(MinCountThread)}; {FormatInt(MaxCountThread)}]: ",
            MinCountThread, MaxCountThread);
    }

    /// <summary>
    /// Инициализация массива случайными числами.
    /// </summary>
    /// <returns> массива заполненный случайными числами.</returns>
    protected int[] InitialArrayRandomData()
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

    /// <summary>
    /// Выполнение действий в многопоточном режиме.
    /// </summary>
    protected virtual void ExecutionWithThread()
    {
        Logger.Debug("Выполнение в многопоточном режиме.");
    }

    /// <summary>
    /// Выполнение действий в однопоточном потоке.
    /// </summary>
    protected virtual void ExecutionWithoutThread()
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
    private int ReadDigitFromConsole(string message, int minValue, int maxValue)
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
                    Logger.Error($"Вводимое значение должно быть в промежутке [{minValue}; {maxValue}]");
                }
            }
            catch (FormatException formatException)
            {
                WriteError("", formatException);
            }
        } while (error);

        return resultRead;
    }

    /// <summary>
    /// Считывание целового числа из консоли.
    /// </summary>
    /// <param name="message">Сообщение перед вводом данных</param>
    /// <returns>Считанное целое число с консоли.</returns>
    protected int ReadDigitFromConsole(string message)
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
                WriteError("Ошибка считывания числа", formatException);
            }
        } while (error);

        return resultRead;
    }

    /// <summary>
    /// Запись ошибки.
    /// </summary>
    /// <param name="errorMessage">Ошибка.</param>
    /// <param name="exception"></param>
    private void WriteError(string errorMessage, Exception exception)
    {
        Logger.Error(errorMessage);
        Logger.Trace(exception);
    }

    /// <summary>
    /// Запуск выполения задачи.
    /// </summary>
    public void Run()
    {
        ReadInputData();

        Array = new int[CountElements];
        Array = InitialArrayRandomData();

        Threads = new Thread[CountThreads];
        Threads.Initialize();

        ExecutionWithoutThread();
        ExecutionWithThread();
    }

    protected void WriteTimeResult()
    {
        Logger.Info($"Время сравнения массивов: {TimeExecution.ElapsedMilliseconds} ms");
    }

    private string FormatInt(int number)
    {
        return string.Format(IntFormat, number);
    }
}