using System;

namespace _11.ExtractBitNumberThree
{
    class ExtractBitNumberThree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number to see its 3-rd bit:");
            uint number = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine((number & 8) >> 3);
        }
    }
}
