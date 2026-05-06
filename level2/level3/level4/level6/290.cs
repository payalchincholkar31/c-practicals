using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter CSV file path: ");
        string path = Console.ReadLine();

        if (File.Exists(path))
        {
            ReadCSV(path);
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }

    static void ReadCSV(string path)
    {
        string[] lines = File.ReadAllLines(path);

        Console.WriteLine("\nCSV File Content:\n");

        foreach (string line in lines)
        {
            string[] values = line.Split(',');

            foreach (string value in values)
            {
                Console.Write(value + "\t");
            }

            Console.WriteLine();
        }
    }
}