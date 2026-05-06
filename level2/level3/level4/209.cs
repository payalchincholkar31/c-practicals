using System;

class SumOfOddNumbers
{
    static void Main()
    {
        int start, end, sum = 0;

        Console.Write("Enter starting number: ");
        start = int.Parse(Console.ReadLine());

        Console.Write("Enter ending number: ");
        end = int.Parse(Console.ReadLine());

        for (int i = start; i <= end; i++)
        {
            if (i % 2 != 0)
            {
                sum += i;
            }
        }

        Console.WriteLine("Sum of odd numbers: " + sum);
    }
}