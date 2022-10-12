namespace Lab1;

/// <summary>
/// Результаты выполнения задачи.
/// </summary>
public struct Result
{
    /// <summary>
    /// Номер задачи.
    /// </summary>
    public string TaskNumber;

    /// <summary>
    /// Количество элементов в последовательности.
    /// </summary>
    public int CountElements;

    /// <summary>
    /// Количество потоков.
    /// </summary>
    public int CountThreads;

    /// <summary>
    /// Время выполнения задачи.
    /// </summary>
    public string Time;

    public override string ToString()
    {
        return string.Format($"{TaskNumber},{CountElements},{CountThreads},{Time}," +
                             $"{Environment.OSVersion}," +
                             $"{Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE")}," +
                             $"{Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER")}," +
                             $"{Environment.ProcessorCount}");
    }
}