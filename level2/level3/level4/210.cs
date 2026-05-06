using System;

class ProductOfDigits
{
    static void Main()
    {
        int number, product = 1, remainder;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        // Handle case when number is 0
        if (number == 0)
        {
            product = 0;
        }
        else
        {
            while (number > 0)
            {
                remainder = number % 10;
                product *= remainder;
                number /= 10;
            }
        }

        Console.WriteLine("Product of digits: " + product);
    }
}