using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;

            Console.WriteLine("Enter first string:");
            str1 = Console.ReadLine();

            Console.WriteLine("Enter second string:");
            str2 = Console.ReadLine();

            Console.WriteLine(
                $"Result string:\n{DuplicateChars(str1, str2)}");

            Console.ReadKey();
        }

        /// <summary>
        /// Doubles characters of the firts string that appear in the second string
        /// </summary>
        static string DuplicateChars(string firstString, string secondString)
        {
            for (int i = 0; i < firstString.Length; i++)
            {
                if (secondString.Contains(firstString[i].ToString()))
                {
                    firstString = firstString.Insert(i+1, firstString[i].ToString());

                    i++;
                }
            }

            return firstString;
        }
    }
}
