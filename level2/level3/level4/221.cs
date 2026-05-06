using System;

class Program
{
    static void Main()
    {
        int number, sum = 0;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        int temp = number;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += digit * digit;
            temp /= 10;
        }

        Console.WriteLine("Sum of squares of digits of " + number + " is: " + sum);
    }
}