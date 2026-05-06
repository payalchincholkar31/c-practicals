using System;

class Program
{
    static void Main()
    {
        int rows, cols;

        Console.Write("Enter number of rows: ");
        rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        cols = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= cols; j++)
            {
                if (i == 1 || i == rows || j == 1 || j == cols)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}