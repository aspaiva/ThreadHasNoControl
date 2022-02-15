using System;
using System.Threading;

static void DoSomething(string What, int HowLong)
{
    Console.WriteLine($"Inicio: {What}");
    Thread.Sleep(HowLong);
    Console.WriteLine($"Fim: {What}");
}

while (true)
{
    new Thread(new ThreadStart(() => DoSomething("1", 2000))).Start();
    new Thread(new ThreadStart(() => DoSomething("2", 2000))).Start();
    new Thread(new ThreadStart(() => DoSomething("3", 2000))).Start();

    var key = Console.ReadKey().Key;
    if (key == ConsoleKey.Enter)
    {
        break;
    }
    Console.WriteLine("de novo...");
}
