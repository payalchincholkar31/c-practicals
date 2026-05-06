using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Stopwatch");
        Console.WriteLine("Press ENTER to START...");
        Console.ReadLine();

        Stopwatch sw = new Stopwatch();
        sw.Start();

        Console.WriteLine("Stopwatch started. Press ENTER to STOP...");
        Console.ReadLine();

        sw.Stop();

        Console.WriteLine("\nElapsed Time:");
        Console.WriteLine("Hours   : " + sw.Elapsed.Hours);
        Console.WriteLine("Minutes : " + sw.Elapsed.Minutes);
        Console.WriteLine("Seconds : " + sw.Elapsed.Seconds);
        Console.WriteLine("Milliseconds: " + sw.ElapsedMilliseconds);
    }
}