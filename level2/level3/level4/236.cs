using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Enter size of square: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                // Print star only for border
                if (i == 1 || i == n || j == 1 || j == n)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}