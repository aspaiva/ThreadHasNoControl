using System;
using System.Threading;

/*
 * Threads cannot control execution order by default
 * This makes us to have more care if methods need 
 * some order after running. Think Asyncly
 * 
 * This console app is in .NET6 which do not require main() function
 */

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
