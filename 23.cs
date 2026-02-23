using System;

namespace AreaOfCircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius * radius;

            Console.WriteLine("Area of the Circle = " + area);

            Console.ReadLine(); // Keeps console open
        }
    }
}