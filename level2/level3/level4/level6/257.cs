using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        if (IsRotation(str1, str2))
            Console.WriteLine("Strings are rotations of each other.");
        else
            Console.WriteLine("Strings are NOT rotations of each other.");
    }

    static bool IsRotation(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;

        string temp = s1 + s1;

        return temp.Contains(s2);
    }
}