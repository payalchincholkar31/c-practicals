using System;

class OctalToDecimal
{
    static void Main()
    {
        int octalNumber, decimalNumber = 0, baseValue = 1, remainder;

        Console.Write("Enter an octal number: ");
        octalNumber = int.Parse(Console.ReadLine());

        while (octalNumber > 0)
        {
            remainder = octalNumber % 10;
            decimalNumber += remainder * baseValue;
            baseValue *= 8;
            octalNumber /= 10;
        }

        Console.WriteLine("Decimal number is: " + decimalNumber);
    }
}