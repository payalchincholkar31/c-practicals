using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        string result = CapitalizeWords(input);

        Console.WriteLine("Result: " + result);
    }

    static string CapitalizeWords(string str)
    {
        string[] words = str.Split(' ');
        string result = "";

        foreach (string word in words)
        {
            if (word.Length > 0)
            {
                result += char.ToUpper(word[0]) + word.Substring(1).ToLower() + " ";
            }
        }

        return result.Trim();
    }
}