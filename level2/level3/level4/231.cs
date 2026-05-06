using System;

class Program
{
    static void Main()
    {
        int rows;

        Console.Write("Enter number of rows: ");
        rows = Convert.ToInt32(Console.ReadLine());

        for (int i = rows; i >= 1; i--)
        {
            // Print leading spaces
            for (int j = rows; j > i; j--)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}