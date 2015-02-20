using System;
//Write a program that reads 3 real numbers from the console and prints their sum.

namespace _01.SumOfThreeNumbers
{
    class SumOfThreeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            double thirdNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Their sum is: " + (firstNumber + secondNumber + thirdNumber));
        }
    }
}
