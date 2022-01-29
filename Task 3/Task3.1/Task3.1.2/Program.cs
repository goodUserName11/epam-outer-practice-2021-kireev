using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[]
            {' ', '.', ',', '!', '?', '-',
            '"', '\'', ':', ';', '(', ')'};

            string[] words;

            Dictionary<string, int> wordsCount;
            double grade;

            ConsoleColor color;
            var baseColor = 
                Console.ForegroundColor;
            string message;

            Console.WriteLine("Enter text:");

            words =
                Console.ReadLine().
                ToLower().
                Split(separators,
                    StringSplitOptions.
                    RemoveEmptyEntries);

            wordsCount = GetWordsCount(words);
            grade = SpeechVariety(wordsCount);

            Console.WriteLine("Words count:");

            foreach (var word in wordsCount)
            {
                Console.WriteLine(string.Format(
                    $"{word.Key,-15}:{word.Value},"));
            }

            Console.WriteLine(
                $"\nMost frequentle used word:\n" +
                $"{GetMostFrequentlyUsedWord(wordsCount)}");

            Console.WriteLine("\nSpeech variety:");

            if (grade > 70)
            {
                color = ConsoleColor.Green;
                message = "Good";
            }
            else if (grade > 60)
            {
                color = ConsoleColor.Yellow;
                message = "OK";
            }
            else
            {
                color = ConsoleColor.Red;
                message = "Bad";
            }

            Console.ForegroundColor = color;
            Console.WriteLine($"{grade:.00}\n" +
                $"{message}");

            Console.ForegroundColor = baseColor;

            Console.ReadKey();
        }

        static Dictionary<string, int> GetWordsCount(string[] words)
        {
            Dictionary<string, int> wordsCount = 
                new Dictionary<string, int>();

            foreach(var word in words)
            {
                if (!wordsCount.
                    ContainsKey(word))
                {
                    wordsCount.Add(word, 1);
                }
                else wordsCount[word]++;
            }

            return wordsCount;
        }

        static string
           GetMostFrequentlyUsedWord(
            Dictionary<string, int> wordsCount)
        {
            string mostUsedWord = 
                wordsCount.ElementAt(0).Key;
            int usedWordCount = 
                wordsCount.ElementAt(0).Value;

            for (int i = 1; i < wordsCount.Count; i++)
            {
                if(usedWordCount < 
                    wordsCount.ElementAt(i).Value)
                mostUsedWord =
                    wordsCount.ElementAt(i).Key;
                usedWordCount =
                    wordsCount.ElementAt(i).Value;
            }

            return mostUsedWord;
        }

        static double SpeechVariety(
            Dictionary<string, int> wordsCount)
        {
            //double constOfVariety = 0.6;
            //double borderOfVariety;

            double avgGrade = 0;
            double maxGrade;

            int allWordsCount = 0;

            foreach (var word in wordsCount)
                allWordsCount += word.Value;

            //borderOfVariety = 
            //    allWordsCount * 
            //    constOfVariety;

            maxGrade = 100 / allWordsCount;

            foreach (var word in wordsCount)
            {
                avgGrade += maxGrade / word.Value;
            }

            return avgGrade;
        }
    }
}
