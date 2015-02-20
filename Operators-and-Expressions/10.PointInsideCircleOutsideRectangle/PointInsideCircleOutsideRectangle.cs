using System;

namespace _10.PointInsideCircleOutsideRectangle
{
    class PointInsideCircleOutsideRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input x coodinate:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input y coodinate:");
            double y = Convert.ToDouble(Console.ReadLine());
            x -= 1;
            y -= 1;
            bool isInsideCircle = (Math.Sqrt(x * x + y * y) <= 1.5);
            bool isOutsideRectangle = (y > 0);
            Console.WriteLine("Inside Circle and outside Rectangle? - " + (isInsideCircle && isOutsideRectangle));

        }
    }
}
