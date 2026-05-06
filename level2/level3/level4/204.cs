using System;

class DecimalToBinary
{
    static void Main()
    {
        int number;
        string binary = "";

        Console.Write("Enter a decimal number: ");
        number = int.Parse(Console.ReadLine());

        if (number == 0)
        {
            Console.WriteLine("Binary: 0");
            return;
        }

        while (number > 0)
        {
            int remainder = number % 2;
            binary = remainder + binary; // prepend
            number /= 2;
        }

        Console.WriteLine("Binary: " + binary);
    }
}