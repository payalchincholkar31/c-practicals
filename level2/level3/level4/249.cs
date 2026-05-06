using System;
using System.Threading;

class Program
{
    static void Main()
    {
        char[] spinner = { '|', '/', '-', '\\' };

        Console.Write("Loading ");

        for (int i = 0; i < 30; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(200);
            Console.Write("\b"); // move cursor back
        }

        Console.WriteLine("\nDone!");
    }
}