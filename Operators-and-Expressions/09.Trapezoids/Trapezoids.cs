using System;

namespace _09.Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input side a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input side b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input height:");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The area of the trapezoid is:" + (h*(a+b)/2));
        }
    }
}
