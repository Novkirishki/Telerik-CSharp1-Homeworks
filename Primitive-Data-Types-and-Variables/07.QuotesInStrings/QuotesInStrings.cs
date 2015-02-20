using System;

namespace _07.QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string a = "The \"use\" of quotations causes difficulties.";
            string b = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
