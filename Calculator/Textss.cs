﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Textss
    {
        public static string Empty(string text)
        {
            text = String.Empty;
            return text;
        }
        public static string TexttoZero(string text)
        {
            text = "0";
            return text;
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