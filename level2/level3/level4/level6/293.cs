using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter source file path: ");
        string sourcePath = Console.ReadLine();

        Console.Write("Enter destination file path: ");
        string destinationPath = Console.ReadLine();

        MoveFile(sourcePath, destinationPath);
    }

    static void MoveFile(string source, string destination)
    {
        try
        {
            if (File.Exists(source))
            {
                File.Move(source, destination);
                Console.WriteLine("File moved successfully!");
            }
            else
            {
                Console.WriteLine("Source file does not exist!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}