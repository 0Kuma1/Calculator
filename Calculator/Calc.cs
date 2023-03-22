using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CalculatorLogic
{
    static string action;
    public static void AdNumber(int value,ref int position,ref Label text,ref double result, ref bool isdelete, ref Label action)
    {
        if (isdelete)
        {
            text.Text = "0";
            isdelete = false;
            action.Text = String.Empty;
        }
        if (text.Text == "0")
        {
            text.Text = value.ToString();
            position--;
            result=int.Parse(text.Text);
        }
        else if (position<14)
        {
            text.Text = text.Text + value.ToString();
            result = int.Parse(text.Text);
        }
        else
        {
            MessageBox.Show($"Your Text is to big");
        }
    }
    public static void DeleteNumber(ref int position,ref Label text,ref double result)
    {
        if(text.Text != "0")
        {
            string temp = "";
            char[] v = text.Text.ToArray();
            for (int i = 0; i < text.Text.Length; i++)
            {
                if (i != position)
                {
                    temp = temp + v[i];
                }
            }
            text.Text = temp;
            position--;
        }
        if (position == 0)
        {
            text.Text= "0";
        }
    }
    public static void DeleteAll(ref int position,ref double result)
    {
        position = 0;
        result = 0;
    }
    public static void Plus(double result,ref int result2)
    {
        action = "+";
        return (int)result;
    }
    public static void Minus(double result,ref int result2)
    {
        result2 = (int)result;
    }
    public static void Multiply(double result,ref int result2)
    {
        result2 = (int)result;
    }
    public static void Divide(double result,ref int result2)
    {
        result2 = (int)result;
    }
    public static void Equals(ref Label text, ref double result, ref Label action, ref string events, ref int result2,ref bool isdelete)
    {
        switch (events)
        {
            case"+":
                action.Text = $"{result2} + {result} =";
                result2 += (int)result;
                text.Text=result2.ToString();
                result2 = 0;
                result = 0;
                isdelete = true;
                break;
            case "-":
                action.Text = $"{result2} - {result} =";
                result2 -= (int)result;
                text.Text = result2.ToString();
                result2 = 0;
                result = 0;
                isdelete = true;
                break;
            case "*":
                action.Text = $"{result2} * {result} =";
                result2 *= (int)result;
                text.Text = result2.ToString();
                result2 = 0;
                result = 0;
                isdelete = true;
                break;
            case "/":
                if (result == 0 && result2 == 0)
                {
                    MessageBox.Show($"Result is undefined");
                }
                else if (result == 0)
                {
                    MessageBox.Show($"Cannot divide by zero");
                }
                else
                {
                    action.Text = $"{result2} / {result} =";
                    if (result2 % result != 0)
                    {
                        double temp1 = result2;
                        double temp2 = (int)result;
                        double temp3 = temp1 / temp2;
                        text.Text = temp3.ToString();
                    }
                    else
                    {
                        result2 /= (int)result;
                        text.Text = result2.ToString();
                    }
                    result2 = 0;
                    result = 0;
                    isdelete = true;
                    }
                break;
        }
    }
    public static void Sqrt(ref Label text, ref double result)
    {
        result = Math.Sqrt(result);
        text.Text = Textss.SubstringStr(result);
        result = double.Parse(text.Text);
    }
    public static void Poww(ref double result)
    {
        result = (int)Math.Pow(result,2);
    }
    public static void MinorPlus(ref double result)
    {
        result = -result;
    }
    public static void Pi(ref double result)
    {
        result = Math.PI;
    }
    public static void E(ref double result)
    {
        result = Math.E;
    }
    public static void Abs(ref double result)
    {
        if(result<0)
        {
            result = -result;
        }
    }
    public static void Fac(ref double result,ref int ress)
    {
        ress = 1;
        for (int i = (int)result; i > 0; i--)
            ress *= i;
        result = ress;
    }
    public static void OneX(ref double result)
    {
        result = 1 / result;
    }
}
