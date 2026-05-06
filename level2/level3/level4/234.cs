using System;

class Program
{
    static void Main()
    {
        int rows;

        Console.Write("Enter number of rows: ");
        rows = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < rows; i++)
        {
            // Print spaces
            for (int space = 0; space < rows - i; space++)
            {
                Console.Write(" ");
            }

            int number = 1;

            for (int j = 0; j <= i; j++)
            {
                Console.Write(number + " ");
                number = number * (i - j) / (j + 1);
            }

            Console.WriteLine();
        }
    }
}