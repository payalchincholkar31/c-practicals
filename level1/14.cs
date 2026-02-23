using System;

namespace PalindromeNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int originalNumber = number;
            int reverse = 0;

            while (number != 0)
            {
                int remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }

            if (originalNumber == reverse)
            {
                Console.WriteLine("The number is a Palindrome.");
            }
            else
            {
                Console.WriteLine("The number is not a Palindrome.");
            }

            Console.ReadLine(); // Keeps console open
        }
    }
}