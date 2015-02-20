using System;

namespace _14.PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 256; i++)
            {
                Console.Write((char)i);
            }
        }
    }
}
