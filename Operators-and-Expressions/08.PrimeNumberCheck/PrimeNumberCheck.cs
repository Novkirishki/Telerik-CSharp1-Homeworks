using System;

namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number to check if it is prime:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            if (number <= 0)
            {
                Console.WriteLine(false);
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number) + 1; i++)
                {
                    if (number == 1 || number == 2 || number == 3)
                        break;
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine(isPrime);
            }
        }
    }
}
