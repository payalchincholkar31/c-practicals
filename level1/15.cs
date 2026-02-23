using System;

namespace ArmstrongNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int originalNumber = number;
            int sum = 0;
            int digits = number.ToString().Length;

            while (number != 0)
            {
                int remainder = number % 10;
                sum += (int)Math.Pow(remainder, digits);
                number = number / 10;
            }

            if (sum == originalNumber)
            {
                Console.WriteLine("The number is an Armstrong Number.");
            }
            else
            {
                Console.WriteLine("The number is not an Armstrong Number.");
            }

            Console.ReadLine(); // Keeps console open
        }
    }
}