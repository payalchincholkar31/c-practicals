using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Basic Salary: ");
        double basic = Convert.ToDouble(Console.ReadLine());

        double hra = basic * 0.20;
        double da = basic * 0.10;
        double ta = basic * 0.05;

        double grossSalary = basic + hra + da + ta;

        Console.WriteLine("\nHRA: " + hra);
        Console.WriteLine("DA: " + da);
        Console.WriteLine("TA: " + ta);
        Console.WriteLine("Gross Salary: " + grossSalary);

        Console.ReadLine();
    }
}