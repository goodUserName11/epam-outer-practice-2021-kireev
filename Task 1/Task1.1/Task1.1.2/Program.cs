using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string asteriskString = "";

            Console.WriteLine("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());

            for(; asteriskString.Length <= number; asteriskString += '*')
            {
                Console.WriteLine(asteriskString);
            }

            Console.ReadKey();
        }
    }
}
