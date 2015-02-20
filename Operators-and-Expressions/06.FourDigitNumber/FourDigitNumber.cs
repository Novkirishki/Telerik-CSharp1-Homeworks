using System;

namespace _06.FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a four digit number:");
            short number = Convert.ToInt16(Console.ReadLine());
            byte d = (byte)(number % 10);
            number /= 10;
            byte c = (byte)(number % 10);
            number /= 10;
            byte b = (byte)(number % 10);
            number /= 10;
            byte a = (byte)(number % 10);
            Console.WriteLine("The sum of the digits is: " + (a + b + c + d));
            Console.WriteLine("The number in reversed order is: " + (d*1000 + c*100 + b*10 + a));
            Console.WriteLine("Last digit in first position: " + (d * 1000 + a * 100 + b * 10 + c));
            Console.WriteLine("Exchanged second and third digits: " + (a * 1000 + c * 100 + b * 10 + d));
        }
    }
}
