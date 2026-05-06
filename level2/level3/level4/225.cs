using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (IsHappy(number))
            Console.WriteLine(number + " is a Happy number.");
        else
            Console.WriteLine(number + " is not a Happy number.");
    }

    static bool IsHappy(int num)
    {
        HashSet<int> seen = new HashSet<int>();

        while (num != 1 && !seen.Contains(num))
        {
            seen.Add(num);
            num = SumOfSquares(num);
        }

        return num == 1;
    }

    static int SumOfSquares(int n)
    {
        int sum = 0;

        while (n > 0)
        {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }

        return sum;
    }
}