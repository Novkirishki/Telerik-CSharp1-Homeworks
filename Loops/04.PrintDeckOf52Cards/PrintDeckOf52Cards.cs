using System;

//Write a program that generates and prints all possible cards from a standard deck of 52 cards 
//(without the jokers). The cards should be printed using the classical notation
//(like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
//Use 2 nested for-loops and a switch-case statement.

namespace _04.PrintDeckOf52Cards
{
    class PrintDeckOf52Cards
    {
        static void Main(string[] args)
        {
            string[] array = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    switch (j)
                    {
                        case 0:
                            Console.Write("{0} of spades, ",array[i]);
                            break;
                        case 1:
                            Console.Write("{0} of clubs, ", array[i]);
                            break;
                        case 2:
                            Console.Write("{0} of hearts, ", array[i]);
                            break;
                        case 3:
                            Console.Write("{0} of diamonds", array[i]);
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
