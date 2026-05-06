using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        ExtractNumbers(input);
    }

    static void ExtractNumbers(string str)
    {
        StringBuilder number = new StringBuilder();

        Console.WriteLine("Numbers found:");

        foreach (char c in str)
        {
            if (char.IsDigit(c))
            {
                number.Append(c);
            }
            else
            {
                if (number.Length > 0)
                {
                    Console.WriteLine(number.ToString());
                    number.Clear();
                }
            }
        }

        // Print last number if exists
        if (number.Length > 0)
        {
            Console.WriteLine(number.ToString());
        }
    }
}