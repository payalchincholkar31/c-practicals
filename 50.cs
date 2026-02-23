using System;

class Program
{
    static void Main()
    {
        // Current date and time
        DateTime now = DateTime.Now;

        Console.WriteLine("Current Date and Time: " + now);
        Console.WriteLine("Date: " + now.ToShortDateString());
        Console.WriteLine("Time: " + now.ToShortTimeString());

        // Specific date
        DateTime specificDate = new DateTime(2026, 2, 23);
        Console.WriteLine("Specific Date: " + specificDate.ToLongDateString());

        // Adding days
        DateTime futureDate = now.AddDays(5);
        Console.WriteLine("Date after 5 days: " + futureDate);

        Console.ReadLine();
    }
}