using System;
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

namespace _04.NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(firstNumber > secondNumber ? firstNumber : secondNumber);
        }
    }
}
