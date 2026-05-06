using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter file path to save CSV (e.g., data.csv): ");
        string path = Console.ReadLine();

        WriteCSV(path);

        Console.WriteLine("CSV file created successfully!");
    }

    static void WriteCSV(string path)
    {
        using (StreamWriter writer = new StreamWriter(path))
        {
            // Writing header
            writer.WriteLine("Id,Name,Age");

            Console.Write("Enter number of records: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Id: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                writer.WriteLine($"{id},{name},{age}");
            }
        }
    }
}