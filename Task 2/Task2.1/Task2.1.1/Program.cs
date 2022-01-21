using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KireevCustoms;

namespace Task2._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] c = new char[] { 'H', 'e', 'l', 'l', 'o'};

            CustomString customString1 = new CustomString(c);
            CustomString customString2 = "Hello there";

            customString1 += ", Human!";

            Console.WriteLine(customString1);

            Console.WriteLine(
                $"{customString1 == customString2}");

            CustomString customString3 = 
                CustomString.FromCharArray(
                    customString2.ToCharArray());

            Console.WriteLine(customString3);

            Console.WriteLine(
                $"{customString2 == customString3}");

            Console.WriteLine(
                $"{customString2.IndexOf('e')}, " +
                $"{customString2.LastIndexOf("e")}, " +
                $"{customString2.Contains("e")}");

            Console.ReadKey();
        }
    }
}
