using System;

class Program
{
    static void Main()
    {
        int rows;

        Console.Write("Enter number of rows: ");
        rows = Convert.ToInt32(Console.ReadLine());

        char ch = 'A';

        for (int i = 1; i <= rows; i++)
        {
            // Print spaces
            for (int j = i; j < rows; j++)
            {
                Console.Write(" ");
            }

            // Print characters
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write(ch);
            }

            ch++; // Move to next character

            Console.WriteLine();
        }
    }
}