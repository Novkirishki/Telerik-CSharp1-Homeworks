using System;
//Write a program that finds the biggest of three numbers.

namespace _05.TheBiggestOfThreeNumbers
{
    class TheBiggestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the third number:");
            double c = double.Parse(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.WriteLine(a);
            }
            else if ( b >= c)
                Console.WriteLine(b);
            else
                Console.WriteLine(c);
        }
    }
}
