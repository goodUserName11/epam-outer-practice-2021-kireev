using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Common;

namespace Task3._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "HelloWorld";

            Console.WriteLine(
                str.
                CheckLanguage().
                ToString());

            Console.ReadKey();
        }
    }
}
