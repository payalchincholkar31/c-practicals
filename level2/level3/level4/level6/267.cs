using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        if (CompareIgnoreCase(str1, str2))
            Console.WriteLine("Strings are equal (ignoring case).");
        else
            Console.WriteLine("Strings are NOT equal.");
    }

    static bool CompareIgnoreCase(string s1, string s2)
    {
        return string.Equals(s1, s2, StringComparison.OrdinalIgnoreCase);
    }
}