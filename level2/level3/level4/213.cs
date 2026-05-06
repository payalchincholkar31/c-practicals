using System;

class Program
{
    static void Main()
    {
        int number, i;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Factors of " + number + " are:");

        for (i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }
}