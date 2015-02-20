using System;

//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.

namespace _12.ZeroSubset
{
    class ZeroSubset
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter five numbers:");
            int[] numbers = new int[5];
            numbers[0] = int.Parse(Console.ReadLine());
            numbers[1] = int.Parse(Console.ReadLine());
            numbers[2] = int.Parse(Console.ReadLine());
            numbers[3] = int.Parse(Console.ReadLine());
            numbers[4] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (numbers[i] + numbers[j] == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", numbers[i], numbers[j]);
                    }
                }
            }


            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    for (int k = j + 1; k < 5; k++)
                    {
                        if (numbers[i] + numbers[j] + numbers[k] == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} = 0", numbers[i], numbers[j], numbers[k]);
                        }
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    for (int k = j+1; k < 5; k++)
                    {
                        for (int l = k+1; l < 5; l++)
                        {
                            if (numbers[i] + numbers[j] + numbers[k] + numbers[l] == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[i], numbers[j], numbers[k], numbers[l]);
                            }
                        }
                    }
                }
            }

            if (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] == 0)
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);

        }
    }
}
