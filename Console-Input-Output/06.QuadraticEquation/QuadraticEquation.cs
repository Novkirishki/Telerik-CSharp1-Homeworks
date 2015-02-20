using System;
//Write a program that reads the coefficients `a`, `b` and `c` of a quadratic equation
//ax<sup>2</sup> + bx + c = 0 and solves it (prints its real roots).

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            double c = double.Parse(Console.ReadLine());
            double D = b * b - 4 * a * c;
            if(D < 0)
                Console.WriteLine("No real roots!");
            else 
            {
                Console.WriteLine("x1= " + (-b + Math.Sqrt(D)) / (2 * a));
                Console.WriteLine("x2= " + (-b - Math.Sqrt(D)) / (2 * a));
            }
        }
    }
}
