using Lab1;

Console.WriteLine("Лабораторная работа 1. Организация параллельно выполняемых потоков и межпроцессное взаимодействие.");


var task1 = new Task1();
task1.ExecutionWithoutThread();

Console.WriteLine("Завершение программы.");