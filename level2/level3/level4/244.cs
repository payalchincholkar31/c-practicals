using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Enter size (odd number recommended): ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i == j || (i + j) == (n + 1))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}