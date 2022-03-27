using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task1._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, resStr;

            Console.WriteLine("Enter a string:");
            str = Console.ReadLine();

            resStr = CapitalizeFirst(str);

            Console.WriteLine($"\nString with Capitalized first letter:\n{resStr}");

            Console.ReadKey();
        }


        /// <summary>
        /// Capitalizes first letter of first word of sentence
        /// </summary>
        /// <param name="str">Initial string</param>
        /// <returns>Capitalized string</returns>
        static string CapitalizeFirst(string str)
        {
            StringBuilder resStr = new StringBuilder(str);
            bool beginingOfSentence = true;

            for (int i = 0; i < resStr.Length; i++)
            {
                if(beginingOfSentence && char.IsLetter(resStr[i]))
                {
                    beginingOfSentence = false;

                    if (char.IsLower(resStr[i])) resStr[i] = char.ToUpper(resStr[i]);
                }
                else if(resStr[i] == '.' || 
                    resStr[i] == '!' || 
                    resStr[i] == '?')
                {
                    beginingOfSentence = true;
                }
            }

            return resStr.ToString();
        }

            //string resStr = "";
            //string[] sentences = str.Split('.','!','?');

            //foreach (var sentence in sentences)
            //{
            //    if (sentence.Length == 0) continue;

            //    char firstChar = sentence.Trim(' ')[0];
            //    if (char.IsLower(firstChar))
            //    {
            //        resStr += sentence.Substring(0, 
            //            sentence.IndexOf(firstChar)) +
            //            sentence.Substring(sentence.IndexOf(firstChar)+1);
            //    }
            //}

            //return resStr;
    }
}
