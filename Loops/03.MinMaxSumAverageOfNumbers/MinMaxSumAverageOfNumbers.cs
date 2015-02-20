using System;

//Write a program that reads from the console a sequence of n integer numbers and
//returns the minimal, the maximal number, the sum and the average of all numbers 
//(displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.


namespace _03.MinMaxSumAverageOfNumbers
{
    class MinMaxSumAverageOfNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many nubers do you want to input?");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int min = array[0];
            int max = array[0];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
                sum += array[i];
            }

            Console.WriteLine("min - {0}, max - {1}, sum - {2}, avg - {3:0.00}", min, max, sum, (double)sum / n);
        }
    }
}
