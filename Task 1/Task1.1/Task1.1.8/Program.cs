using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr3d = new int[3, 3, 3];

            Random random = new Random();

            Console.WriteLine("Initial array:");

            for (int i = 0; i < arr3d.GetLength(0); i++)
            {
                Console.WriteLine($"Slice {i}");
                for (int j = 0; j < arr3d.GetLength(1); j++)
                {
                    for (int k = 0; k < arr3d.GetLength(2); k++)
                    {
                        arr3d[i, j, k] = random.Next(-9,9);

                        Console.Write($"{arr3d[i, j, k]}; ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("No positive array:");

            for (int i = 0; i < arr3d.GetLength(0); i++)
            {
                Console.WriteLine($"Slice {i}");
                for (int j = 0; j < arr3d.GetLength(1); j++)
                {
                    for (int k = 0; k < arr3d.GetLength(2); k++)
                    {
                        if(arr3d[i, j, k] > 0) 
                            arr3d[i, j, k] = 0;

                        Console.Write($"{arr3d[i, j, k]}; ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
