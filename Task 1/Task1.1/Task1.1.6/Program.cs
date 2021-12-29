using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool[] textParams = new bool[] {false, false, false};
            string textParamsInfo;

            do
            {
                textParamsInfo = "";

                if (textParams[0]) textParamsInfo += "Bold, ";
                if (textParams[1]) textParamsInfo += "Italic, ";
                if (textParams[2]) textParamsInfo += "Underline";

                if (textParamsInfo == "") textParamsInfo = "None";

                if (textParamsInfo[textParamsInfo.Length - 1] == ' ')
                    textParamsInfo = 
                        textParamsInfo.Substring(0, 
                        textParamsInfo.Length - 2);

                Console.WriteLine(
                    "Text params: {0}\n" +
                    "Enter:\n" +
                    "  1: bold\n" +
                    "  2: italic\n" +
                    "  3: underline\n" +
                    "  4: to exit", textParamsInfo);

                number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        textParams[0] = !textParams[0];
                        break;
                    case 2:
                        textParams[1] = !textParams[1];
                        break;
                    case 3:
                        textParams[2] = !textParams[2];
                        break;
                }
            } while (number != 4);
        }
    }
}
