using Lab1;

Console.WriteLine("Лабораторная работа 1. Организация параллельно выполняемых потоков и межпроцессное взаимодействие.");
const string Help = "help";
const string Quit = "q";

bool error = true;
inputData:
do
{
    Console.Write("Введите данные (help - справка) : ");
    var resultRead = Console.ReadLine();
    Command command = Command.Undefined;
    
    if (resultRead.Equals(Help))
    {
        command = Command.Help;
    } else if (resultRead.Equals(Quit))
    {
        command = Command.Quit;
    }
    else
    {
        int numberTask = 0;
        try
        {
            numberTask = Convert.ToInt32(resultRead);

            switch (numberTask)
            {
                case 1:
                {
                    command = Command.Task1;
                    break;
                }
                case 2:
                {
                    command = Command.Task2;
                    break;
                }
                case 3:
                {
                    command = Command.Task3;
                    break;
                }
                case 4:
                {
                    command = Command.Task4;
                    break;
                }
                case 5:
                {
                    command = Command.Task5;
                    break;
                }
                case 6:
                {
                    command = Command.Task6;
                    break;
                }
                case 7:
                {
                    command = Command.Task7;
                    break;
                }
                case 8:
                {
                    command = Command.Task8;
                    break;
                }
                default: 
                    command = Command.Undefined;
                    break;
            }
            
        }
        catch (FormatException formatException)
        {
            Console.WriteLine("Ошибка считывания. Для просмотра доступных команд введите help");
            goto inputData;
        }
    }

    error = ExecuteCommand(command);

} while (error);

Console.WriteLine("Завершение программы.");

bool ExecuteCommand(Command command)
{
    switch (command)
    {
        case Command.Help:
        {
            Console.WriteLine("Список доступных команд.");
            break;
        }
        case Command.Quit:
        {
            return false;
        }
        default: Console.WriteLine("Неопознанная команда. Повторите ввод");
            break;
    }

    return true;
}