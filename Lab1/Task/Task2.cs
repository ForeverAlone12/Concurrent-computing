namespace Lab1.Task;

public class Task2 : AbstractTask
{
    public Task2() : base("Task2","Кодировка последовательности C")
    {
	}
	
	protected override void ExecutionWithoutThread()
    {
        base.ExecutionWithoutThread();
		
	}

     protected override void ExecutionWithThread()
    {
        base.ExecutionWithThread();
		
	} 

     protected override int CalculateThreadFunction(int begin, int end) 
    {
		
		return 0;
	}
 	
}