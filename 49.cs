using System;

class Program
{
    static void Main()
    {
        double num1 = 25;
        double num2 = 7.8;
        double num3 = -10;

        Console.WriteLine("Square Root of 25: " + Math.Sqrt(num1));
        Console.WriteLine("Power (5^3): " + Math.Pow(5, 3));
        Console.WriteLine("Absolute Value of -10: " + Math.Abs(num3));
        Console.WriteLine("Maximum of 25 and 7.8: " + Math.Max(num1, num2));
        Console.WriteLine("Minimum of 25 and 7.8: " + Math.Min(num1, num2));
        Console.WriteLine("Rounded value of 7.8: " + Math.Round(num2));

        Console.ReadLine();
    }
}