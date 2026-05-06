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

        CopyFile(sourcePath, destinationPath);
    }

    static void CopyFile(string source, string destination)
    {
        try
        {
            if (File.Exists(source))
            {
                File.Copy(source, destination, true); // overwrite = true
                Console.WriteLine("File copied successfully!");
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