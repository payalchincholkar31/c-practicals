using System;

namespace CompoundInterestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Principal Amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Rate of Interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Time (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());

            double amount = principal * Math.Pow((1 + rate / 100), time);
            double compoundInterest = amount - principal;

            Console.WriteLine("Compound Interest = " + compoundInterest);
            Console.WriteLine("Total Amount = " + amount);

            Console.ReadLine(); // Keeps console open
        }
    }
}