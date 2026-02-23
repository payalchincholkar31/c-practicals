using System;

class Program
{
    static void Main()
    {
        // Declaring nullable type
        int? number = null;

        if (number.HasValue)
        {
            Console.WriteLine("Value: " + number.Value);
        }
        else
        {
            Console.WriteLine("Number is null");
        }

        // Assigning value
        number = 10;

        Console.WriteLine("After assigning value: " + number);

        Console.ReadLine();
    }
}