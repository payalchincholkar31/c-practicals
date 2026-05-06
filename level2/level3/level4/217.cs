using System;

class Program
{
    static void Main()
    {
        double number;

        Console.Write("Enter a number: ");
        number = Convert.ToDouble(Console.ReadLine());

        double cubeRoot = FindCubeRoot(number);

        Console.WriteLine("Cube root of " + number + " is: " + cubeRoot);
    }

    static double FindCubeRoot(double num)
    {
        return Math.Pow(num, 1.0 / 3.0);
    }
}
