using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.Write("Enter seconds for countdown: ");
        int seconds = Convert.ToInt32(Console.ReadLine());

        for (int i = seconds; i >= 0; i--)
        {
            Console.Clear();
            Console.WriteLine("Countdown Timer");
            Console.WriteLine("----------------");
            Console.WriteLine("Time Left: " + i + " seconds");

            Thread.Sleep(1000);
        }

        Console.WriteLine("\nTime's up!");
    }
}