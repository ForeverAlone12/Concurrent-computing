using System.Diagnostics;

namespace Lab1;

public interface ITask
{
    /// <summary>
    /// Выполнение действий в многопоточном режиме.
    /// </summary>
    public void ExecutionWithThread();
    
    /// <summary>
    /// Выполнение действий в однопоточном потоке.
    /// </summary>
    public void ExecutionWithoutThread();
}