using System;

namespace AreaOfRectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter breadth of the rectangle: ");
            double breadth = Convert.ToDouble(Console.ReadLine());

            double area = length * breadth;

            Console.WriteLine("Area of the Rectangle = " + area);

            Console.ReadLine(); // Keeps console open
        }
    }
}