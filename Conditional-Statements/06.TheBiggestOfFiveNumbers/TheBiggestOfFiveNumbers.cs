using System;

//Write a program that finds the biggest of five numbers by using only five if statements.

namespace _06.TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the third number:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the fourth number:");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the fifth number:");
            double e = double.Parse(Console.ReadLine());

            double max;

            if (a >= b && a >= c)
            {
                max = a;
            }
            else if (b >= c)
                max = b;
            else
                max = c;

            if (max >= d && max >= e)
            {
   
            }
            else if (d >= e)
                max = d;
            else
                max = e;

            //I have used only 4 if statements
            Console.WriteLine(max);
        }
    }
}
