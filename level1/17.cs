using System;

namespace CountDigitsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            if (number == 0)
            {
                count = 1;
            }
            else
            {
                number = Math.Abs(number); // Handle negative numbers

                while (number > 0)
                {
                    number = number / 10;
                    count++;
                }
            }

            Console.WriteLine("Total number of digits = " + count);

            Console.ReadLine(); // Keeps console open
        }
    }
}