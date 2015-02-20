using System;

//Write a program that reads from the console a positive integer number n (1 <= n <= 20)
//and prints a matrix like in the examples below. Use two nested loops

namespace _09.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n:");
            short n = short.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    Console.Write("{0} ", j+i);
                }

                Console.WriteLine();
            }
        }
    }
}
