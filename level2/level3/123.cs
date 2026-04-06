using System;

class Program
{
    // Method to check a number and throw exception if invalid
    static void CheckNumber(int number)
    {
        if (number < 0)
        {
            // Throwing an exception
            throw new ArgumentException("Number cannot be negative.");
        }
        else
        {
            Console.WriteLine("Valid number: " + number);
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            CheckNumber(num);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Exception caught: " + ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Please enter a valid integer.");
        }
        finally
        {
            Console.WriteLine("Program execution completed.");
        }

        Console.ReadLine();
    }
}