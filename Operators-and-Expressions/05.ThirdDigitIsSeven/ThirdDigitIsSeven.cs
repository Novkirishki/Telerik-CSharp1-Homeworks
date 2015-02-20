using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ThirdDigitIsSeven
{
    class ThirdDigitIsSeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number to see if the thirs digit is 7:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((number/100)%10 == 7);
        }
    }
}
