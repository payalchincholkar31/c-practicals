using System;

class Program
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        int result = DigitalRoot(number);

        Console.WriteLine("Digital Root is: " + result);
    }

    static int DigitalRoot(int num)
    {
        while (num >= 10)
        {
            num = SumOfDigits(num);
        }
        return num;
    }

    static int SumOfDigits(int num)
    {
        int sum = 0;

        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        return sum;
    }
}