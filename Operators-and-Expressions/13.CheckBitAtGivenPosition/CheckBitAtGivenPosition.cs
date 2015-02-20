using System;

namespace _13.CheckBitAtGivenPosition
{
    class CheckBitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number to see if its n-th bit is 1:");
            uint number = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Insert n:");
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(((number & Convert.ToUInt32(Math.Pow(2, n))) >> (int)n) == 1);
        }
    }
}
