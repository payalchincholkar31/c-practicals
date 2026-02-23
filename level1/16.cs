using System;

namespace SumOfDigitsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;   // Get last digit
                number = number / 10; // Remove last digit
            }

            Console.WriteLine("Sum of digits = " + sum);

            Console.ReadLine(); // Keeps console open
        }
    }
}