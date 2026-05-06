using System;

class Program
{
    static void Main()
    {
        int number, temp, digit;
        int sum = 0, product = 1;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        temp = number;

        while (temp > 0)
        {
            digit = temp % 10;
            sum += digit;
            product *= digit;
            temp /= 10;
        }

        if (sum == product)
        {
            Console.WriteLine(number + " is a Spy number.");
        }
        else
        {
            Console.WriteLine(number + " is not a Spy number.");
        }
    }
}