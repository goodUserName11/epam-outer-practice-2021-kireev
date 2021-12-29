using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for(int number = 3; number < 1000; number++) 
            {
                if(number % 3 == 0 || number % 5 == 0)
                {
                    sum += number;
                }
            }

            Console.WriteLine($"sum is {sum}");
            Console.ReadKey();
        }
    }
}
