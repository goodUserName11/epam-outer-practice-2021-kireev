using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int eliminationNumber;
            List<AbsolutlyAbstractHuman> humans;

            int i = 1;

            Console.WriteLine("Enter number of elements:");
            int.TryParse(
                Console.ReadLine(),
                out number);

            humans =
                CreateFilledHumanList(number);

            Console.WriteLine(
                "Enter the number of people to be " +
                "eliminated each round:");
            int.TryParse(
                Console.ReadLine(),
                out eliminationNumber);

            while (humans.Count >= 
                eliminationNumber)
            {
                humans.RemoveAt(eliminationNumber - 1);

                Console.WriteLine(
                    $"Round {i}: Human was eliminated. " +
                    $"Humans left: {humans.Count}");

                i++;
            }
            Console.WriteLine(
                "Game over. Can't eliminate more humans");

            Console.ReadKey();
        }

        static List<AbsolutlyAbstractHuman> 
            CreateFilledHumanList(int count)
        {
            var humans =
                new List<AbsolutlyAbstractHuman>();

            for (int i = 0;i < count; i++)
            {
                humans.Add(
                    new AbsolutlyAbstractHuman());
            }

            return humans;
        }
    }
}
