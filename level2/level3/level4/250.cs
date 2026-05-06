using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().ToLower();

        if (IsPangram(input))
            Console.WriteLine("The string is a Pangram.");
        else
            Console.WriteLine("The string is NOT a Pangram.");
    }

    static bool IsPangram(string str)
    {
        bool[] alphabet = new bool[26];

        foreach (char c in str)
        {
            if (c >= 'a' && c <= 'z')
            {
                alphabet[c - 'a'] = true;
            }
        }

        foreach (bool letter in alphabet)
        {
            if (!letter)
                return false;
        }

        return true;
    }
}