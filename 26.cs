using System;

namespace TypeCastingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Casting (int → double)
            int num = 10;
            double doubleNum = num;  

            Console.WriteLine("Implicit Casting:");
            Console.WriteLine("Integer value = " + num);
            Console.WriteLine("Converted to Double = " + doubleNum);

            // Explicit Casting (double → int)
            double value = 9.78;
            int intValue = (int)value;

            Console.WriteLine("\nExplicit Casting:");
            Console.WriteLine("Double value = " + value);
            Console.WriteLine("Converted to Integer = " + intValue);

            Console.ReadLine(); // Keeps console open
        }
    }
}