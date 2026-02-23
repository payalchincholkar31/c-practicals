using System;

class Program
{
    static void Main()
    {
        // Demonstrating do-while loop
        Console.WriteLine("Numbers from 1 to 10:");

        int i = 1;

        do
        {
            Console.WriteLine(i);
            i++;   // increment
        }
        while (i <= 10);

        Console.ReadLine();
    }
}