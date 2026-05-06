using System;

class Program
{
    static void Main()
    {
        int rows, number = 1;

        Console.Write("Enter number of rows: ");
        rows = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(number + " ");
                number++;
            }

            Console.WriteLine();
        }
    }
}