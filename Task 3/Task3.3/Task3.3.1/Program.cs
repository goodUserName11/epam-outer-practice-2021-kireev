using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Task3._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> l = new List<int>() {1,2,3};

            //l.set

            int[] arr = new int[] { 1, 4, 8, 1, 1, 8 };

            arr.ForEach(item => Console.WriteLine(item));

            Console.WriteLine(
                $"Sum: {arr.Sum()}\n" +
                $"Avg: {arr.Avg():.00}\n" +
                $"Most frequently occurs: \n" +
                $"{arr.MostFrequentlyOccurs()}");

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
