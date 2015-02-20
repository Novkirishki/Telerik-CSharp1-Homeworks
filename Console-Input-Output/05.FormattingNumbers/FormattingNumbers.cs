using System;
//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

namespace _05.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            float c = float.Parse(Console.ReadLine());
            string firstColumn = a.ToString("X");
            string secondColumn = Convert.ToString(a, 2);
            string thirdColumn = String.Format("{0:0.00}",b);
            string fourthColumn = String.Format("{0:0.000}", c);
            Console.WriteLine(firstColumn.PadRight(10, ' ') + "|" + secondColumn.PadLeft(10, '0') + "|" + thirdColumn.PadLeft(10, ' ') + "|" + fourthColumn.PadRight(10, ' '));
        }
    }
}
