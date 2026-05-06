using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().ToLower();

        int count = CountConsonants(input);

        Console.WriteLine("Number of consonants: " + count);
    }

    static int CountConsonants(string str)
    {
        int count = 0;

        foreach (char c in str)
        {
            if (c >= 'a' && c <= 'z')
            {
                if (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u')
                {
                    count++;
                }
            }
        }

        return count;
    }
}