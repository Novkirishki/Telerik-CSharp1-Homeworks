using System;

//Write a program that, for a given two integer numbers n and x, 
//calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

namespace _05.Calculate
{
    class Calculate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input x:");
            int x = int.Parse(Console.ReadLine());
            double factorial = 1;
            double sum = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i != 0)
                {
                    factorial *= i;
                }

                sum += factorial / Math.Pow(x, i);
            }

            Console.WriteLine("S = {0:0.00000}", sum);
        }
    }
}
