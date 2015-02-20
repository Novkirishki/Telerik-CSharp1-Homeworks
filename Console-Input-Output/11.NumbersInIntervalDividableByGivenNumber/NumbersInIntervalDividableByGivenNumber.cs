using System;
//Write a program that reads two positive integer numbers and prints how many
//numbers p exist between them such that the reminder of the division by 5 is 0

namespace _11.NumbersInIntervalDividableByGivenNumber
{
    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the start of the interval:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the end of the interval:");
            int end = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                    counter++;
            }
            Console.WriteLine("Count of numbers divisible by 5 in the given interval: {0}", counter);
        }
    }
}
