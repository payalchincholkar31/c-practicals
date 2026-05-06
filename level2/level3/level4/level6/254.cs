using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        string shortestWord = FindShortestWord(input);

        Console.WriteLine("Shortest word is: " + shortestWord);
    }

    static string FindShortestWord(string str)
    {
        string[] words = str.Split(' ');

        string shortest = words[0];

        foreach (string word in words)
        {
            if (word.Length < shortest.Length)
            {
                shortest = word;
            }
        }

        return shortest;
    }
}