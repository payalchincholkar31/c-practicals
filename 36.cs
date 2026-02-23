using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        // Generate random number between 1 and 100
        int number = random.Next(1, 101);

        Console.WriteLine("Random Number: " + number);

        Console.ReadLine();
    }
}