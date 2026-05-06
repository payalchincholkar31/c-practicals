using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Enter number of columns: ");
        n = Convert.ToInt32(Console.ReadLine());

        // Zig-zag always uses 3 rows
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if ((i + j) % 4 == 0 || (i == 2 && j % 4 == 0))
                    Console.Write("* ");
                else
                    Console.Write("  ");
            }

            Console.WriteLine();
        }
    }
}