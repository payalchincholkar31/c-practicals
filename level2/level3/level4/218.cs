using System;

class Program
{
    static void Main()
    {
        int number, square, sum = 0;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        square = number * number;

        int temp = square;

        while (temp > 0)
        {
            sum += temp % 10;
            temp /= 10;
        }

        if (sum == number)
        {
            Console.WriteLine(number + " is a Neon number.");
        }
        else
        {
            Console.WriteLine(number + " is not a Neon number.");
        }
    }
}