﻿using System;

//Write a program that enters from the console a positive integer n and
//prints all the numbers from 1 to n, on a single line, separated by a space.

namespace NumbersFromOneToN
{
    class NumbersFromOneToN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
