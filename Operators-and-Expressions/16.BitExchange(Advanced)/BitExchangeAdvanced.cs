using System;

namespace _16.BitExchange_Advanced_
{
    class BitExchangeAdvanced
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number to exchange bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1}:");
            uint number = Convert.ToUInt32(Console.ReadLine());
            int p, q; //positions of bit sequences to swap
            Console.WriteLine("Insert p:");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert q:");
            q = Convert.ToInt32(Console.ReadLine());
            int k; //number of consecutive bits in each sequence
            Console.WriteLine("Insert k:");
            k = Convert.ToInt32(Console.ReadLine());
            if (q + k > 32 || p + k > 32 || q < 0 || p < 0)
            {
                Console.WriteLine("out of range");
            }
            else if (Math.Abs(p - q) < k)
            {
                Console.WriteLine("overlapping");
            }
            else 
            {
                uint result;
                uint tempResult = ((number >> p) ^ (number >> q)) & (((uint)1 << k) - 1);
                result = number ^ ((tempResult << p) | (tempResult << q));
                Console.WriteLine("The result is: " + result);
            }
        }
    }
}
