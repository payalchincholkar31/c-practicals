using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter base number: ");
        int baseNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter exponent: ");
        int exponent = Convert.ToInt32(Console.ReadLine());

        int result = 1;

        for (int i = 1; i <= exponent; i++)
        {
            result = result * baseNum;
        }

        Console.WriteLine("Power = " + result);

        Console.ReadLine();
    }
}