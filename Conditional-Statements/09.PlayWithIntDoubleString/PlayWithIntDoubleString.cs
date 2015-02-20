using System;

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

namespace _09.PlayWithIntDoubleString
{
    class PlayWithIntDoubleString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type: \n 1--> int \n 2--> double \n 3--> string");
            short choice = short.Parse(Console.ReadLine());
            switch (choice)
            {   
                case 1:
                    Console.WriteLine("Please enter an integer:");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a + 1);
                    break;
                case 2:
                    Console.WriteLine("Please enter a double:");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine(b + 1);
                    break;
                case 3:
                    Console.WriteLine("Please enter a string:");
                    string c = Console.ReadLine();
                    Console.WriteLine(c + "*");
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }
    }
}
