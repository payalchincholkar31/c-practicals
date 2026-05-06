using System;

class Program
{
    static void Main()
    {
        int size;

        Console.Write("Enter size of checkerboard: ");
        size = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if ((i + j) % 2 == 0)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}