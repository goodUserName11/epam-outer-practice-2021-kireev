using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string str;

            Console.WriteLine("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                int height = i + 1;

                string preStr = new string(' ', number - height);
                str = preStr;

                for (int j = 1; j <= height; j++, str = preStr)
                {
                    for (int k = 0; k < height - j; str += ' ', k++) ;
                    for (int k = 0; k < j + j - 1; str += '*', k++) ;

                    Console.WriteLine(str);
                }
            }

            Console.ReadKey();
        }
    }
}
