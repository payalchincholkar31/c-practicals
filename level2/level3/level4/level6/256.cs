using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = ToggleCase(input);

        Console.WriteLine("Toggled string: " + result);
    }

    static string ToggleCase(string str)
    {
        char[] chars = str.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsUpper(chars[i]))
                chars[i] = char.ToLower(chars[i]);
            else if (char.IsLower(chars[i]))
                chars[i] = char.ToUpper(chars[i]);
        }

        return new string(chars);
    }
}