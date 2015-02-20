using System;

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

namespace _06.Calculate2
{
    class Calculate2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n (1 < n < 100):");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input k (1 < k < n):");
            int k = int.Parse(Console.ReadLine());
            double result = 1;

            for (int i = n; i > k; i--)
            {
                result *= i;
            }

            Console.WriteLine("The result is {0}", result);
        }
    }
}
