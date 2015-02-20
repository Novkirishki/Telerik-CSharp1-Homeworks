using System;
//Write a program that reads the radius r of a circle and prints its perimeter
//and area formatted with 2 digits after the decimal point.

namespace _03.CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());
            double perimeter = 2 * radius * Math.PI;
            double area = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine("The perimeter is " + Math.Round(perimeter,2) + " and the area is " + Math.Round(area,2));
        }
    }
}
