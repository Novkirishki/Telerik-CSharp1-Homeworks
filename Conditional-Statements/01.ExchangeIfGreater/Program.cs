using System;
//Write an if-statement that takes two double variables a and b and exchanges their values 
//if the first one is greater than the second one. As a result print the values a and b, separated by a space.

namespace _01.ExchangeIfGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input b: ");
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(b + " " + a);
            }
            else
                Console.WriteLine(a + " " + b);
        }
    }
}
