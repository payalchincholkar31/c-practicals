
using System;

namespace ReverseNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;

            while (number != 0)
            {
                int remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }

            Console.WriteLine("Reversed Number = " + reverse);

            Console.ReadLine(); // Keeps console open
        }
    }
}