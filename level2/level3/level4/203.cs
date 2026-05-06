using System;

class BinaryToDecimal
{
    static void Main()
    {
        int binaryNumber, decimalNumber = 0, baseValue = 1, remainder;

        Console.Write("Enter a binary number: ");
        binaryNumber = int.Parse(Console.ReadLine());

        while (binaryNumber > 0)
        {
            remainder = binaryNumber % 10;
            decimalNumber += remainder * baseValue;
            baseValue *= 2;
            binaryNumber /= 10;
        }

        Console.WriteLine("Decimal number is: " + decimalNumber);
    }
}