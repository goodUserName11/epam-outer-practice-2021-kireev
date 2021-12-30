using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int lowercaseWordsCounter;

            Console.WriteLine("Enter a string:");
            str = Console.ReadLine();

            lowercaseWordsCounter = LowercaseWordsCount(str);

            Console.WriteLine($"There are {lowercaseWordsCounter} " +
                $"words that starts with lowecase letter");

            Console.ReadKey();
        }

        /// <summary>
        /// Counts a number of words in a string that start with lower case letter
        /// </summary>
        static int LowercaseWordsCount(string str)
        {
            int lowercaseWordsCounter = 0;
            int wordLenght = 0;

            foreach (var character in str)
            {
                if (char.IsLower(character) && wordLenght == 0)
                {
                    lowercaseWordsCounter++;
                    wordLenght++;
                }
                else if (!char.IsLetter(character))
                {
                    wordLenght = 0;
                }
                else
                {
                    wordLenght++;
                }
            }

            return lowercaseWordsCounter;
        }
    }
}
