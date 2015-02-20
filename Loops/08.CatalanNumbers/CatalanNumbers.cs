using System;

//Write a program to calculate the nth Catalan number by given n (1 < n < 100).

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n:");
            short n = short.Parse(Console.ReadLine());
            double catalan = 1;

            for (int i = 2; i <= n; i++)
            {
                catalan *= (double)(n + i) / i;
            }

            Console.WriteLine("The catalan number for {0} is {1}", n, catalan);
        }
    }
}
