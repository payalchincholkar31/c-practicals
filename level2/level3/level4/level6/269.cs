using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        string result = ReverseWords(input);

        Console.WriteLine("Reversed sentence: " + result);
    }

    static string ReverseWords(string str)
    {
        string[] words = str.Split(' ');
        Array.Reverse(words);

        return string.Join(" ", words);
    }
}