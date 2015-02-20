using System;

namespace _15.BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number to exchange bits 3, 4 and 5 with bits 24, 25 and 26:");
            uint number = Convert.ToUInt32(Console.ReadLine());
            int i, j; //positions of bit sequences to swap
            i = 3;
            j = 24;
            int n = 3; //number of consecutive bits in each sequence
            uint result;
            uint tempResult = ((number >> i) ^ (number >> j)) & (((uint)1 << n) - 1);
            result = number ^ ((tempResult << i) | (tempResult << j));
            Console.WriteLine("The result is: " + result);
        }
    }
}
