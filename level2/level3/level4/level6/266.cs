using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char[] charArray = ConvertToCharArray(input);

        Console.WriteLine("Character Array:");

        foreach (char c in charArray)
        {
            Console.Write(c + " ");
        }
    }

    static char[] ConvertToCharArray(string str)
    {
        return str.ToCharArray();
    }
}