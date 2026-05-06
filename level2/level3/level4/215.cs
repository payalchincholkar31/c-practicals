using System;

class Program
{
    static void Main()
    {
        int number;
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (IsPerfectCube(number))
        {
            Console.WriteLine(number + " is a perfect cube.");
        }
        else
        {
            Console.WriteLine(number + " is not a perfect cube.");
        }
    }

    static bool IsPerfectCube(int num)
    {
        int cubeRoot = (int)Math.Round(Math.Pow(num, 1.0 / 3.0));
        return cubeRoot * cubeRoot * cubeRoot == num;
    }
}