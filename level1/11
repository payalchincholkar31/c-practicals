using System;

namespace FactorialProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            long factorial = 1;

            if (number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine("Factorial of " + number + " is: " + factorial);
            }

            Console.ReadLine(); // Keeps console open
        }
    }
}