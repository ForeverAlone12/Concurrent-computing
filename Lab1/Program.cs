using Lab1;
using Lab1.Task;

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Лабораторная работа 1. Организация параллельно выполняемых потоков и межпроцессное взаимодействие.");
Console.WriteLine("Для запуска задачи введите её номер.");
Console.WriteLine("Для выхода нажмите q");
Console.ResetColor();
Console.WriteLine();

bool error = true;
do
{
    Console.Write("Введите данные: ");
    var resultRead = Console.ReadLine();

    var task = new Task3();
    task.Run();

} while (error);

Console.WriteLine("Завершение программы.");

