using System;

class ReverseNumberRecursion
{
    static int reverse = 0;

    static void Reverse(int number)
    {
        if (number == 0)
            return;

        int remainder = number % 10;
        reverse = reverse * 10 + remainder;

        Reverse(number / 10);
    }

    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        Reverse(number);

        Console.WriteLine("Reversed number: " + reverse);
    }
}