using System;

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

namespace _13.BinaryToDecimalNumber
{
    class BinaryТоDecimalNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the binary number");
            string line = Console.ReadLine();
            char[] digits = line.ToCharArray();
            double number = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == '1')
                {
                    number +=  Math.Pow(2, digits.Length - i-1);
                }
            }

            Console.WriteLine("The number is: {0}", number);
        }
    }
}
