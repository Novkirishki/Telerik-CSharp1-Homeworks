using System;
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

namespace _07.SumOfFiveNumbers
{
    class SumOfFiveNumbers
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += double.Parse(numbers[i]);
            }
            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
