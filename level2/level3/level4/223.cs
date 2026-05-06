using System;

class Program
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        int nextPrime = FindNextPrime(number);

        Console.WriteLine("Next prime number is: " + nextPrime);
    }

    static int FindNextPrime(int num)
    {
        int candidate = num + 1;

        while (true)
        {
            if (IsPrime(candidate))
                return candidate;

            candidate++;
        }
    }

    static bool IsPrime(int n)
    {
        if (n < 2) return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}