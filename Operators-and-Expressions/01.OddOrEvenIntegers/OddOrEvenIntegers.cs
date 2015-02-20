using System;

namespace _01.OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to see if it is odd:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number%2 != 0);
        }
    }
}
