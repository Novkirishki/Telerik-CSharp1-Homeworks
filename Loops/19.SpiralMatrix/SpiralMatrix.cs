using System;

//Write a program that reads from the console a positive integer number n (1 = n = 20) 
//and prints a matrix holding the numbers from 1 to n*n in the form of square spiral.

namespace _19.SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n:");
            int n = short.Parse(Console.ReadLine());
            int counter = 1;
            int row = 0;
            int col = 0;
            int[,] matrix = new int[n, n];

            while (counter < n * n )
            {

                for (int i = row; i < n - row - 1; i++)
                {
                    col = i;
                    matrix[row, col] = counter;
                    counter++;
                }
                col++;
                for (int i = row; i < col; i++)
                {
                    row = i;
                    matrix[row, col] = counter;
                    counter++;
                }
                row++;
                for (int i = col; i > n - row - 1; i--)
                {
                    col = i;
                    matrix[row, col] = counter;
                    counter++;
                }
                col--;
                for (int i = row; i > col; i--)
                {
                    row = i;
                    matrix[row, col] = counter;
                    counter++;
                }
            }

            if (counter == n * n)
            {
                matrix[n/2, n/2] = counter;
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0:000} ", matrix[i,j]);
                }
                Console.WriteLine();
            }


        }
    }
}
