using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max;
            int[] arr = new int[10];

            Random random = new Random();

            Console.WriteLine("Initial array:");

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 100);

                Console.Write($"{arr[i]}; ");
            }

            Console.WriteLine("\n");

            min = FindMin(arr);
            max = FindMax(arr);

            arr = SortArray(arr);

            Console.WriteLine(
                $"Minimum value: {min}\n" +
                $"Maximum value: {max}\n\n" +
                $"Sorted array:");

            foreach(int item in arr)
            {
                Console.Write($"{item}; ");
            }

            Console.WriteLine();

            Console.ReadKey();
        }

        /// <summary>
        /// Finds minimum value in array
        /// </summary>
        /// <returns>The smallest value of array</returns>
        static int FindMin(int[] array)
        {
            int min = array[0];

            for(int i = 1; i < array.Length; i++) 
            {
                if (array[i] < min) min = array[i];
            }

            return min;
        }

        /// <summary>
        /// Finds maximum value in array
        /// </summary>
        /// <returns>The largest value of array</returns>
        static int FindMax(int[] array)
        {
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }

            return max;
        }

        /// <summary>
        /// Sorts an array (cocktail sort)
        /// </summary>
        /// <returns>Sorted array</returns>
        static int[] SortArray(int[] array)
        {
            int[] arr = new int[array.Length];
            bool hasSwaps;

            array.CopyTo(arr, 0);

            for (int i = 0; i < arr.Length / 2; i++)
            {
                hasSwaps = false;

                for (int j = i; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        hasSwaps = true;
                    }
                }

                for (int j = arr.Length - 2 - i; j > i; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        Swap(ref arr[j - 1], ref arr[j]);
                        hasSwaps = true;
                    }
                }

                if (!hasSwaps) break;
            }

            return arr;
        }

        /// <summary>
        /// Swap values of two variables
        /// </summary>
        static void Swap(ref int elem1, ref int elem2)
        {
            int tmp = elem1;
            elem1 = elem2;
            elem2 = tmp;
        }
    }
}
