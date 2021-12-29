using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int width, length;

            do
            {
                Console.WriteLine("Enter length of rectangle:");
                length = Convert.ToInt32(Console.ReadLine());

                if (length <= 0) 
                    Console.WriteLine("Error: length connot be less than 1\n");

            } while (length <= 0);

            do
            {
                Console.WriteLine("Enter width of rectangle:");
                width = Convert.ToInt32(Console.ReadLine());

                if (width <= 0)
                    Console.WriteLine("Error: width connot be less than 1\n");

            } while (width <= 0);

            Console.WriteLine("\nArea of rectangle is {0}", length * width);

            Console.ReadKey();
        }
    }
}
