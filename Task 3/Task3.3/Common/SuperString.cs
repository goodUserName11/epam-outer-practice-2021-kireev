using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Common
{
    public enum Languages
    {
        None = 0,
        English = 1,
        Russian = 2,
        Number = 3,
        Mixed = 4
    }

    public static class SuperString
    {
        public static Languages CheckLanguage(this string str)
        {
            Regex russian = 
                new Regex(@"^[А-ЯА-яЁё]+$");
            Regex english = 
                new Regex(@"^[A-Za-z]+$");
            Regex number = 
                new Regex(@"^\d+$"); ;

            if (russian.IsMatch(str))
                return Languages.Russian;
            else if (english.IsMatch(str))
                return Languages.English;
            else if (number.IsMatch(str))
                return Languages.Number;
            else
                return Languages.Mixed;
        }
    }
}
