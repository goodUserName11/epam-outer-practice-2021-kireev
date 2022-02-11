using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = new List<double>();
            var darr = new DynamicArray<double>();
            CycledDynamicArray<double> cycDarr;


            l1.Add(1);
            l1.Add(2);
            l1.Add(3);

            darr = new DynamicArray<double>(10);
            Console.WriteLine($"{darr.Capacity}");

            darr = new DynamicArray<double>(l1);
            Console.WriteLine($"{darr[0]:.00}, {darr[-1]:.00}");

            darr.Add(10);
            Console.WriteLine($"{ darr[-1]:00.}");

            darr.AddRange(l1);
            Console.WriteLine($"{ darr[-1]:.00}");

            darr.Insert(0, 4);
            darr.Insert(7, 5);
            Console.WriteLine($"{darr.Length}");
            foreach (var item in darr)
            {
                Console.Write($"{item};");
            }
            Console.WriteLine();

            darr.Remove(-1);
            Console.WriteLine($"{darr.Length}");

            foreach (var item in darr)
            {
                Console.Write($"{item};");
            }
            Console.WriteLine();

            Console.WriteLine($"{darr.GetEnumerator()}");

            darr.Capacity = 20;

            Console.WriteLine(darr.Capacity);
            foreach (var item in darr.ToArray())
            {
                Console.Write($"{item};");
            }
            Console.WriteLine();

            darr = 
                (DynamicArray<double>)
                darr.Clone();

            foreach (var item in darr)
            {
                Console.Write($"{item};");
            }
            Console.WriteLine();

            cycDarr = new CycledDynamicArray<double>(darr);
            int count = 0;
            foreach (var item in cycDarr)
            {
                Console.WriteLine($"{count++}. {cycDarr.Darr[count % cycDarr.Darr.Length]}");

                if (count > 100) break;
            }

            Console.ReadKey();
        }
    }
}
