using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int count = CountSpecialCharacters(input);

        Console.WriteLine("Number of special characters: " + count);
    }

    static int CountSpecialCharacters(string str)
    {
        int count = 0;

        foreach (char c in str)
        {
            if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
            {
                count++;
            }
        }

        return count;
    }
}