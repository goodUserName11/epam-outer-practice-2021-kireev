using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr2d = new int[3, 3];
            int evenSum = 0;

            Random random = new Random();

            Console.WriteLine("Initial array:");

            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    arr2d[i, j] = random.Next(1,10);

                    Console.Write($"{arr2d[i,j]}; ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    if (i + j % 2 == 0)
                        evenSum += arr2d[i,j];
                }
            }

            Console.WriteLine($"Sum of even positions: {evenSum}");

            Console.ReadKey();
        }
    }
}
