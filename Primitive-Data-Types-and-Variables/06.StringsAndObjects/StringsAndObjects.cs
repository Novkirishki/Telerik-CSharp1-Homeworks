using System;

namespace _06.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string hello = "Hello ";
            string world = "World";
            object concat = hello + world;
            string sentence = Convert.ToString(concat);
            Console.WriteLine(sentence);
        }
    }
}
