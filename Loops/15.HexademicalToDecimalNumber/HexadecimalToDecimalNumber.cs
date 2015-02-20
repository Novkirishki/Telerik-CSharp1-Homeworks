using System;

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

namespace HexadecimalToDecimalNumber
{
    class HexademicalToDecimalNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a hexademical number:");
            string number = Console.ReadLine();
            number = number.ToLower();
            long result = 0;

            for (int i = 0; i < number.Length; i++)
            {
                switch (number[i])
                {
                    case '1':
                        result += (long)(Math.Pow(16, number.Length - i - 1) * 1);
                        break;
                    case '2':
                        result += (long)(Math.Pow(16, number.Length - i - 1) * 2);
                        break;
                    case '3':
                        result += (long)(Math.Pow(16, number.Length - i - 1) * 3);
                        break;
                    case '4':
                        result += (long)(Math.Pow(16, number.Length - i - 1) * 4);
                        break;
                    case '5':
                        result += (long)(Math.Pow(16, number.Length - i - 1) * 5);
                        break;
                    case '6':
                        result += (long)(Math.Pow(16, number.Length - i - 1) * 6);
                        break;
                    case '7':
                        result += (long)(Math.Pow(16, number.Length - i - 1) * 7);
                        break;
                    case '8':
                        result += (long)(Math.Pow(16, number.Length - i - 1) * 8);
                        break;
                    case '9':
                        result += (long)(Math.Pow(16, number.Length - i - 1) * 9);
                        break;
                    case 'a':
                        result += (long)(Math.Pow(16, number.Length - i - 1) * 10);
                        break;
                    case 'b':
                        result += (long)(Math.Pow(16, number.Length - i - 1) * 11);
                        break;
                    case 'c':
                        result += (long)(Math.Pow(16, number.Length - i - 1) * 12);
                        break;
                    case 'd':
                        result += (long)(Math.Pow(16, number.Length - i - 1) * 13);
                        break;
                    case 'e':
                        result += (long)(Math.Pow(16, number.Length - i - 1) * 14);
                        break;
                    case 'f':
                        result += (long)(Math.Pow(16, number.Length - i - 1) * 15);
                        break;
                    default:
                        Console.WriteLine("wrong number");
                        break;
                }
            }

            Console.WriteLine("The number in decimal is {0}", result);
        }
    }
}
