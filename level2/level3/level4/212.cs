using System;

class CountEvenOddDigits
{
    static void Main()
    {
        int number, remainder;
        int evenCount = 0, oddCount = 0;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        if (number == 0)
        {
            evenCount = 1; // 0 is even
        }
        else
        {
            while (number > 0)
            {
                remainder = number % 10;

                if (remainder % 2 == 0)
                    evenCount++;
                else
                    oddCount++;

                number /= 10;
            }
        }

        Console.WriteLine("Even digits: " + evenCount);
        Console.WriteLine("Odd digits: " + oddCount);
    }
}