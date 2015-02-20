using System;

namespace _09.ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            int buf = a;
            a = b;
            b = buf;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
