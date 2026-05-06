using System;

class Program
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        int smallest = FindSmallestDigit(number);

        Console.WriteLine("Smallest digit is: " + smallest);
    }

    static int FindSmallestDigit(int num)
    {
        num = Math.Abs(num); // Handle negative numbers

        int smallest = 9;

        while (num > 0)
        {
            int digit = num % 10;

            if (digit < smallest)
                smallest = digit;

            num /= 10;
        }

        return smallest;
    }
}