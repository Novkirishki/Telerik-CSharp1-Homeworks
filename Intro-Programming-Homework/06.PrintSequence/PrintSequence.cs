﻿using System;

namespace _06.PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 12; i++)
            {
                Console.WriteLine(i*Math.Pow(-1,i));
            }
        }
    }
}
