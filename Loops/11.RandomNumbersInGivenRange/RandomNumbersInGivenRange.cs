using System;

//Write a program that enters 3 integers n,
//min and max (min != max) and prints n random numbers in the range [min...max].

namespace _11.RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input min:");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Input max:");
            int max = int.Parse(Console.ReadLine());
            Random rand = new Random();
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", rand.Next(min, max + 1));
            }
        }
    }
}
