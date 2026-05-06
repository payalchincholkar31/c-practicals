using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = RemoveVowels(input);

        Console.WriteLine("String after removing vowels: " + result);
    }

    static string RemoveVowels(string str)
    {
        StringBuilder result = new StringBuilder();

        foreach (char c in str)
        {
            char lower = char.ToLower(c);

            if (lower != 'a' && lower != 'e' && lower != 'i' && lower != 'o' && lower != 'u')
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}