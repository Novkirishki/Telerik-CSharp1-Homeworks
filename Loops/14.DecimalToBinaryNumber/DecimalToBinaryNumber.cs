using System;

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

namespace _14.DecimalToBinaryNumber
{
    class DecimalToBinaryNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            int n = int.Parse(Console.ReadLine());
            string binary = "";

            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    binary += '0';
                }
                else
                    binary += '1';
                n /= 2;
            }

            if (binary == "")
            {
                binary = "0";
            }

            char[] array = binary.ToCharArray();
            Array.Reverse(array);
            binary = new string(array);

            Console.WriteLine("The number in binary is: {0}", binary);
        }
    }
}
