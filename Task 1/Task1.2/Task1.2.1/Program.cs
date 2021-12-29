using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            double avgLength;

            Console.WriteLine("Enter a sentence:");
            sentence = Console.ReadLine();

            avgLength = CalculateAverageWordLength(sentence);

            Console.WriteLine($"Average word length of the sentence is {avgLength:.##}");

            Console.ReadKey();
        }

        static double CalculateAverageWordLength(string sentence)
        {
            double avgLength = 0;
            int wordsCounter = 0;

            if (string.IsNullOrWhiteSpace(sentence))
                return 0;

            string[] pseudowords = sentence.Trim(' ').Split(' ');

            foreach (var pseudoword in pseudowords)
            {
                double wordLength = 0;
                for (int i = 0; i < pseudoword.Length; i++)
                {
                    if (char.IsLetter(pseudoword[i])) wordLength++;
                }

                if(pseudoword.Length > 0 && wordLength > 0)
                {
                    avgLength += wordLength;
                    wordsCounter++;
                }
            }

            avgLength /= wordsCounter;

            return avgLength;
        }
    }
}
