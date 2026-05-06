using System;

class Program
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        int prevPrime = FindPreviousPrime(number);

        if (prevPrime == -1)
            Console.WriteLine("No previous prime number exists.");
        else
            Console.WriteLine("Previous prime number is: " + prevPrime);
    }

    static int FindPreviousPrime(int num)
    {
        for (int i = num - 1; i >= 2; i--)
        {
            if (IsPrime(i))
                return i;
        }
        return -1; // No prime found
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