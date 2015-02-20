using System;

namespace _12.ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number to see its n-th bit:");
            uint number = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Insert n:");
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine((number & Convert.ToUInt32(Math.Pow(2,n))) >> (int)n);
        }
    }
}
