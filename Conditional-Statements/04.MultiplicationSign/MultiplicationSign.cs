using System;
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

namespace _04.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the third number:");
            double c = double.Parse(Console.ReadLine());
            char result;

            if (a == 0 || b == 0 || c == 0)
            {
                result = '0';
            }
            else if (a > 0)
            {
                if ((b > 0 && c < 0) || (b < 0 && c > 0))
                {
                    result = '-';
                }
                else
                {
                    result = '+';
                }
            }
            else
            {
                if ((b > 0 && c < 0) || (b < 0 && c > 0))
                {
                    result = '+';
                }
                else
                {
                    result = '-';
                }
            }
            Console.WriteLine(result);
        }
    }
}
