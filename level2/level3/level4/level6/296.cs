using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter file path: ");
        string path = Console.ReadLine();

        GetFileSize(path);
    }

    static void GetFileSize(string path)
    {
        try
        {
            if (File.Exists(path))
            {
                FileInfo fileInfo = new FileInfo(path);

                long sizeInBytes = fileInfo.Length;
                double sizeInKB = sizeInBytes / 1024.0;
                double sizeInMB = sizeInKB / 1024.0;

                Console.WriteLine("File Size:");
                Console.WriteLine(sizeInBytes + " Bytes");
                Console.WriteLine(sizeInKB + " KB");
                Console.WriteLine(sizeInMB + " MB");
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