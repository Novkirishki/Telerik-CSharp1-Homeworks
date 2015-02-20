using System;
//Write a program that reads a number `n` and prints on the console the first `n` members 
//of the Fibonacci sequence (at a single line, separated by comma and space - `, `) :
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            int b = 1;
            int buf;
            string numbers = "0";
            for (int i = 1; i < n; i++)
            {
                numbers =numbers + ", " + a;
                buf = a;
                a = b;
                b = b + buf;
            }
            Console.WriteLine(numbers);
        }
    }
}
