using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string compressed = CompressString(input);

        Console.WriteLine("Compressed string: " + compressed);
    }

    static string CompressString(string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;

        StringBuilder result = new StringBuilder();

        int count = 1;

        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] == str[i - 1])
            {
                count++;
            }
            else
            {
                result.Append(str[i - 1]);
                result.Append(count);
                count = 1;
            }
        }

        // Append last character group
        result.Append(str[str.Length - 1]);
        result.Append(count);

        return result.ToString();
    }
}