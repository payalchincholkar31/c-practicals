using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter compressed string: ");
        string input = Console.ReadLine();

        string expanded = ExpandString(input);

        Console.WriteLine("Expanded string: " + expanded);
    }

    static string ExpandString(string str)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];

            // If character is alphabet
            if (char.IsLetter(ch))
            {
                int num = 0;

                // Read full number (may be multiple digits)
                while (i + 1 < str.Length && char.IsDigit(str[i + 1]))
                {
                    num = num * 10 + (str[i + 1] - '0');
                    i++;
                }

                // Expand character
                for (int j = 0; j < num; j++)
                {
                    result.Append(ch);
                }
            }
        }

        return result.ToString();
    }
}