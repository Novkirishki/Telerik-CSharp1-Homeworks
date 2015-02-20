using System;

namespace _02.GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight to see how much it wights on the moon:");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(17*number/100);
        }
    }
}
