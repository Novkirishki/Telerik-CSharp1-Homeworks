using System;

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

namespace _12.RandomizeTheNumbers
{
    class RandomizeTheNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random rand = new Random();
            int position = 0;

            for (int i = 1; i < n + 1; i++)
            {
                do
                {
                    position = rand.Next(n);
                } while (array[position] != 0);

                array[position] = i;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
