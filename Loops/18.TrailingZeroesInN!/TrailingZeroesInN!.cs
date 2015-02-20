using System;

//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.

namespace _18.TrailingZeroesInN_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            long number = int.Parse(Console.ReadLine());
            long counter = 0;
            long buffer;

            for (long i = 1; i < number + 1; i++)
            {
                buffer = i;
                while (buffer % 5 == 0)
                {
                    counter++;
                    buffer /= 5;
                }
            }

            Console.WriteLine("The number of trailing zeroes int n! is {0}", counter);
        }
    }
}
