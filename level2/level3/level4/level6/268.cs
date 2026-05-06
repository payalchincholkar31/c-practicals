using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        string result = RemoveDuplicateWords(input);

        Console.WriteLine("After removing duplicates: " + result);
    }

    static string RemoveDuplicateWords(string str)
    {
        string[] words = str.Split(' ');
        HashSet<string> seen = new HashSet<string>();
        StringBuilder result = new StringBuilder();

        foreach (string word in words)
        {
            if (!seen.Contains(word))
            {
                seen.Add(word);
                result.Append(word + " ");
            }
        }

        return result.ToString().Trim();
    }
}