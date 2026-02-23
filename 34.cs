
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Demonstrating break statement:");
        
        for (int i = 1; i <= 10; i++)
        {
            if (i == 6)
            {
                break;  // Stops the loop when i is 6
            }
            Console.WriteLine(i);
        }

        Console.WriteLine("\nDemonstrating continue statement:");

        for (int i = 1; i <= 10; i++)
        {
            if (i == 6)
            {
                continue;  // Skips number 6
            }
            Console.WriteLine(i);
        }

        Console.ReadLine();
    }
}