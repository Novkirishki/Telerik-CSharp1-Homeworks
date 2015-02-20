using System;

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            int odd_product = 1;
            int even_produckt = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    odd_product *= int.Parse(numbers[i]);
                }
                else
                    even_produckt *= int.Parse(numbers[i]);
            }

            if (odd_product == even_produckt)
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No");
        }
    }
}
