using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string str = "";

            Console.WriteLine("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= number; i++, str = "")
            {
                for (int j = 0; j < number - i; str += ' ', j++) ;
                for (int j = 0; j < i + i-1; str += '*', j++) ;

                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
