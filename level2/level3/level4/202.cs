using System;

class HCFRecursion
{
    // Recursive function to find HCF (GCD)
    static int FindHCF(int a, int b)
    {
        if (b == 0)
            return a;
        else
            return FindHCF(b, a % b);
    }

    static void Main()
    {
        int num1, num2;

        Console.Write("Enter first number: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = int.Parse(Console.ReadLine());

        int hcf = FindHCF(num1, num2);

        Console.WriteLine("HCF of " + num1 + " and " + num2 + " is: " + hcf);
    }
}