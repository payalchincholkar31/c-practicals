using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter file path to delete: ");
        string path = Console.ReadLine();

        DeleteFile(path);
    }

    static void DeleteFile(string path)
    {
        try
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("File deleted successfully!");
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}