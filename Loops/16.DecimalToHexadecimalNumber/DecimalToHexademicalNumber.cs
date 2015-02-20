using System;

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

namespace _16.DecimalToHexadecimalNumber
{
    class DecimalToHexademicalNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            long number = long.Parse(Console.ReadLine());
            string hex = "";

            while (number > 0)
            {
                switch (number % 16)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        hex += (number % 16);
                        break;
                    case 10:
                        hex += "A";
                        break;
                    case 11:
                        hex += "B";
                        break;
                    case 12:
                        hex += "C";
                        break;
                    case 13:
                        hex += "D";
                        break;
                    case 14:
                        hex += "E";
                        break;
                    case 15:
                        hex += "F";
                        break; 
                }

                number /= 16;
            }

            if (hex == "")
            {
                hex = "0";
            }

            char[] array = hex.ToCharArray();
            Array.Reverse(array);
            hex = new string(array);

            Console.WriteLine("The number in hexademical is: {0}", hex);

        }
    }
}
