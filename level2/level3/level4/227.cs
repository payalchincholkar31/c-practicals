using System;

class Program
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        int largest = FindLargestDigit(number);

        Console.WriteLine("Largest digit is: " + largest);
    }

    static int FindLargestDigit(int num)
    {
        int largest = 0;

        num = Math.Abs(num); // Handle negative numbers

        while (num > 0)
        {
            int digit = num % 10;

            if (digit > largest)
                largest = digit;

            num /= 10;
        }

        return largest;
    }
}