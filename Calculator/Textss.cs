using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Textss
    {
        //Позабирати зайве
        //Перенести зміні в calc
        public static string TextToZero()
        {
            return "0";
        }
        public static string TextwithAction(string action , string actionm , string text)
        {
            action = text + " " + actionm;
            return action;
        }
        public static string ActionText(string text,string action)
        {
            return text = action;
        }
        public static string ResultToString(string text, double result)
        {
            return text = result.ToString();
        }
        public static string SubstringStr(string text, double result)
        {
            text= result.ToString();
            return text = text.Substring(0, 15);
        }
    }
}
