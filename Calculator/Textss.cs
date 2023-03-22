using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Textss
    {
        public static string TextToZero()
        {
            return "0";
        }
        public static string TextwithAction(string actionm , string text)
        {
            return text + " " + actionm;
        }
        public static string ActionText(string action)
        {
            return action;
        }
        public static string ResultToString( double result)
        {
            return result.ToString();
        }
        public static string SubstringStr(double result)
        {
            return result.ToString().Substring(0, 15);
        }
    }
}
