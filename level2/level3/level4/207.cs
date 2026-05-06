using System;

class AutomorphicNumber
{
    static void Main()
    {
        int number, square, temp, digits = 0;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        square = number * number;
        temp = number;

        // Count digits in the number
        while (temp > 0)
        {
            digits++;
            temp /= 10;
        }

        int lastDigits = square % (int)Math.Pow(10, digits);

        // Check Automorphic
        if (lastDigits == number)
        {
            Console.WriteLine(number + " is an Automorphic Number.");
        }
        else
        {
            Console.WriteLine(number + " is NOT an Automorphic Number.");
        }
    }
}