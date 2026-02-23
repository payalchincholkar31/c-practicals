using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter total number of days: ");
        int totalDays = Convert.ToInt32(Console.ReadLine());

        int years = totalDays / 365;
        int remainingDays = totalDays % 365;

        int months = remainingDays / 30;
        int days = remainingDays % 30;

        Console.WriteLine("\nYears: " + years);
        Console.WriteLine("Months: " + months);
        Console.WriteLine("Days: " + days);

        Console.ReadLine();
    }
}