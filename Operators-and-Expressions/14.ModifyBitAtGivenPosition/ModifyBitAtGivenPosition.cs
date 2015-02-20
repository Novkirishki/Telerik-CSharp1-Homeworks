using System;

namespace _14.ModifyBitAtGivenPosition
{
    class ModifyBitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number to change the bit of n-th position:");
            uint number = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Insert n:");
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Insert the value of the bit (0 or 1):");
            byte b = Convert.ToByte(Console.ReadLine());
            if (b == 0)
            {
                if ((((number & Convert.ToUInt32(Math.Pow(2, n))) >> (int)n)) != b)
                {
                    number -= (uint) Math.Pow(2, n);
                }
            }
            else if ((((number & Convert.ToUInt32(Math.Pow(2, n))) >> (int)n)) != b)
            {
                number += (uint)Math.Pow(2, n);
            }
            Console.WriteLine(number);
        }
    }
}
