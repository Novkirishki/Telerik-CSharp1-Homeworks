using System;

namespace _13.ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            if (Math.Abs(a - b) < 0.000001)
            {
                Console.WriteLine(true);
            }
            else
                Console.WriteLine(false);
        }
    }
}
