using System;

//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

namespace _17.CalculateGCD
{
    class CalculateGCD
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input b:");
            int b = int.Parse(Console.ReadLine());
            int r;

            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }

            Console.WriteLine("The greatest common divisor is {0}", a);
        }
    }
}
