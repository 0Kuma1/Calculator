using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Textss
    {
        //public static string Empty()
        //{
        //    text = String.Empty;
        //    return String.Empty;
        //}
        public static string TextToZero()
        {
            return "0";
        }
        public static string TextWithAction(string actionm, string text)
        => text + " " + actionm;
        //public static string ActionText(string text,string action)
        //{
        //    return text = action;
        //}
        //public static string ResultToString(string text, double result)
        //{
        //    return text = result.ToString();
        //}
        public static string SubstringStr(/*string text,*/ double result)
        {
            //text= result.ToString();
            return /*text = */result.ToString().Substring(0, 15);
        }
    }
}
