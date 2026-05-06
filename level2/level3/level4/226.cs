using System;

class Program
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Collatz Sequence:");

        GenerateCollatz(number);
    }

    static void GenerateCollatz(int n)
    {
        while (n != 1)
        {
            Console.Write(n + " ");

            if (n % 2 == 0)
                n = n / 2;
            else
                n = 3 * n + 1;
        }

        Console.WriteLine("1");
    }
}