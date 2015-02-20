using System;

namespace _10.PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 1002; i++)
            {
                Console.WriteLine(i * Math.Pow(-1, i));
            }
        }
    }
}
