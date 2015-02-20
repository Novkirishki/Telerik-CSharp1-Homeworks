using System;

//In combinatorics, the number of ways to choose k different members out of a group of n
//different elements (also known as the number of combinations) is calculated by the following formula:
//formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
//Try to use only two loops.

namespace _07.Calculate3
{
    class Calculate3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n (1 < n < 100):");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input k (1 < k < n):");
            int k = int.Parse(Console.ReadLine());
            double result1 = 1;
            double result2 = 1;

            for (int i = n; i > k; i--)
            {
                result1 *= i;
            }

            for (int i = 1; i <= n - k; i++)
            {
                result2 *= i;
            }

            Console.WriteLine("The result is {0}", result1 / result2);
        }
    }
}
