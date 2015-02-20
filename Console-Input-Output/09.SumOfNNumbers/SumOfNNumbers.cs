using System;
//Write a program that enters a number `n` and after that enters more `n` numbers and calculates and prints their `sum`.

namespace _09.SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i < n + 1; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("The sum is: {0}" , sum);
        }
    }
}
