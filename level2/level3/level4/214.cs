using System;

class Program
{
    static void Main()
    {
        int number;
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (IsPerfectSquare(number))
        {
            Console.WriteLine(number + " is a perfect square.");
        }
        else
        {
            Console.WriteLine(number + " is not a perfect square.");
        }
    }

    static bool IsPerfectSquare(int num)
    {
        int root = (int)Math.Sqrt(num);
        return root * root == num;
    }
}