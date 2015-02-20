using System;
//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.

namespace _07.SortThreeNumbersWithNestedIfs
{
    class SortThreeNumbersWithNestedIfs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the third number:");
            double c = double.Parse(Console.ReadLine());

            if (a >= b && a >= c && b >= c)
                Console.WriteLine("{0} {1} {2}", a, b, c);
            else if (a >= b && a >= c && c >= b)
                Console.WriteLine("{0} {1} {2}", a, c, b);
            else if (b >= a && b >= c && a >= c)
                Console.WriteLine("{0} {1} {2}", b, a, c);
            else if (b >= a && b >= c && c >= a)
                Console.WriteLine("{0} {1} {2}", b, c, a);
            else if (c >= b && c >= a && a >= b)
                Console.WriteLine("{0} {1} {2}", c, a, b);
            else if (c >= b && c >= a && b >= a)
                Console.WriteLine("{0} {1} {2}", c, b, a);
        }
    }
}
