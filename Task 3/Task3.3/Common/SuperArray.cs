using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// Extentions for array of integer
    /// </summary>
    public static class SuperArray
    {
        /// <summary>
        /// Performs the specified action with 
        /// each element of the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public static void ForEach
            (this int[] array, Action<int> action)
        {
            foreach (var item in array)
            {
                action?.Invoke(item);
            } 
        }

        /// <summary>
        /// Get the sum of elements of the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int Sum(this int[] array)
        {
            int sum = 0;

            foreach (var item in array)
            {
                sum += item;
            }

            return sum;
        }

        /// <summary>
        /// Get the average value of the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static double Avg(this int[] array)
        {
            double avg;

            avg = Sum(array) / (double)array.Length;

            return avg;
        }

        /// <summary>
        /// Gets most frequently occuring item
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int MostFrequentlyOccurs(this int[] array)
        {
            int mostFrequentlyItem = 0;
            int frequencyValue = 0;
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (var item in array)
            {
                if (frequency.ContainsKey(item)) 
                    frequency[item]++;
                else
                    frequency.Add(item, 1);

                if(frequency[item] > frequencyValue)
                {
                    mostFrequentlyItem = item;
                    frequencyValue = frequency[item];
                }
            }

            return mostFrequentlyItem;
        }
    }
}
