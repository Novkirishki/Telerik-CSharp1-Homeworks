using System;
//Write a program that reads an integer number `n` from the console and prints all the numbers
//in the interval `[1..n]`, each on a single line.

namespace _08.NumbersFromOneToN
{
    class NumbersFromOneToN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n+1; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
