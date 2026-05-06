using System;

class Program
{
    static void Main()
    {
        DisplaySystemInfo();
    }

    static void DisplaySystemInfo()
    {
        Console.WriteLine("=== System Information ===\n");

        Console.WriteLine("Machine Name      : " + Environment.MachineName);
        Console.WriteLine("OS Version        : " + Environment.OSVersion);
        Console.WriteLine("Processor Count   : " + Environment.ProcessorCount);
        Console.WriteLine("User Name         : " + Environment.UserName);
        Console.WriteLine("Current Directory : " + Environment.CurrentDirectory);
        Console.WriteLine("64-bit OS         : " + Environment.Is64BitOperatingSystem);
        Console.WriteLine("CLR Version       : " + Environment.Version);
        Console.WriteLine("System Up Time(ms): " + Environment.TickCount64);
    }
}