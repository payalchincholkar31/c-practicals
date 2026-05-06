using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = RemoveDuplicates(input);

        Console.WriteLine("String after removing duplicates: " + result);
    }

    static string RemoveDuplicates(string str)
    {
        StringBuilder result = new StringBuilder();
        bool[] seen = new bool[256]; // ASCII tracking

        foreach (char c in str)
        {
            if (!seen[c])
            {
                seen[c] = true;
                result.Append(c);
            }
        }

        return result.ToString();
    }
}