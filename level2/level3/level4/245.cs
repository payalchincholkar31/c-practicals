using System;

class Program
{
    static void Main()
    {
        int rows;

        Console.Write("Enter number of rows: ");
        rows = Convert.ToInt32(Console.ReadLine());

        // Top inverted pyramid
        for (int i = rows; i >= 1; i--)
        {
            for (int j = rows; j > i; j--)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        // Bottom pyramid
        for (int i = 2; i <= rows; i++)
        {
            for (int j = rows; j > i; j--)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}