using System;

namespace GcdLcmApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int a = num1;
            int b = num2;

            // Finding GCD using Euclidean Algorithm
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            int gcd = a;
            int lcm = (num1 * num2) / gcd;

            Console.WriteLine("GCD = " + gcd);
            Console.WriteLine("LCM = " + lcm);

            Console.ReadLine(); // Keeps console open
        }
    }
}