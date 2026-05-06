using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter directory path: ");
        string path = Console.ReadLine();

        ListFiles(path);
    }

    static void ListFiles(string path)
    {
        try
        {
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);

                Console.WriteLine("Files in directory:");

                if (files.Length == 0)
                {
                    Console.WriteLine("No files found.");
                }
                else
                {
                    foreach (string file in files)
                    {
                        Console.WriteLine(file);
                    }
                }
            }
            else
            {
                Console.WriteLine("Directory does not exist!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}