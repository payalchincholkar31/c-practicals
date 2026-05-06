using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter file path: ");
        string path = Console.ReadLine();

        int lineCount = CountLines(path);

        Console.WriteLine("Number of lines in file: " + lineCount);
    }

    static int CountLines(string path)
    {
        try
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                return lines.Length;
            }
            else
            {
                Console.WriteLine("File does not exist!");
                return 0;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return 0;
        }
    }
}