using System;

namespace FibonacciSeriesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of terms: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int first = 0, second = 1;

            Console.WriteLine("Fibonacci Series:");

            for (int i = 1; i <= n; i++)
            {
                Console.Write(first + " ");

                int next = first + second;
                first = second;
                second = next;
            }

            Console.ReadLine(); // Keeps console open
        }
    }
}