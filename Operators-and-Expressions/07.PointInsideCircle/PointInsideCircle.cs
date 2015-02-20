using System;

namespace _07.PointInsideCircle
{
    class PointInsideCircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input x coodinate:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input y coodinate:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(x*x+y*y) <= 2);
        }
    }
}
