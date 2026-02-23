using System;

namespace PrimeNumbersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter starting number: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter ending number: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPrime numbers in the given range:\n");

            for (int num = start; num <= end; num++)
            {
                if (num < 2)
                    continue;

                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(num + " ");
                }
            }

            Console.ReadLine(); // Keeps console open
        }
    }
}