using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int nonNegativeSum = 0;

            Random random = new Random();

            Console.WriteLine("Initial array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-10, 10);

                Console.Write($"{arr[i]}; ");
            }

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    nonNegativeSum += arr[i];
            }

            Console.WriteLine($"Non negative sum: {nonNegativeSum}");

            Console.ReadKey();
        }
    }
}
