using System;

namespace _03.DivideBySevenAndFive
{
    class DivideBySevenAndFive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to see if it devides by 7 and 5:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number % 35 == 0);
        }
    }
}
