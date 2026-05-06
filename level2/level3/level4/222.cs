using System;

class Program
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (IsCircularPrime(number))
            Console.WriteLine(number + " is a Circular Prime.");
        else
            Console.WriteLine(number + " is not a Circular Prime.");
    }

    static bool IsCircularPrime(int num)
    {
        string str = num.ToString();
        int len = str.Length;

        for (int i = 0; i < len; i++)
        {
            int rotated = int.Parse(str);

            if (!IsPrime(rotated))
                return false;

            // Rotate digits
            str = str.Substring(1) + str[0];
        }

        return true;
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