using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CalculatorLogic
{

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
    public static void DeleteAll(ref int position,ref Label text,ref double result,ref Label action)
    {
        position = 0;
        text.Text = "0";
        result = 0;
        action.Text = String.Empty;
    }

    public static void Plus(ref Label text, ref double result,ref Label action,ref string events,ref int result2)
    {
        action.Text = text.Text+" +";
        events="+";
        text.Text = "0";
        result2= (int)result;
    }
    public static void Minus(ref Label text, ref double result, ref Label action, ref string events, ref int result2)
    {
        action.Text = text.Text + " -";
        events = "-";
        text.Text = "0";
        result2 = (int)result;
    }
    public static void Multiply(ref Label text, ref double result, ref Label action, ref string events, ref int result2)
    {
        action.Text = text.Text + " " + "*";
        events = "*";
        text.Text = "0";
        result2 = (int)result;
    }
    public static void Divide(ref Label text, ref double result, ref Label action, ref string events, ref int result2)
    {
        action.Text = text.Text + " " + "/";
        events = "/";
        text.Text = "0";
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
                            float temp1 = result2;
                            float temp2 = (int)result;
                            float temp3 = temp1 / temp2;
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
    //!!!!!!!!
    public static double Sqrt(double result)
    {
        return (int)Math.Sqrt(result);
    }
    public static void Poww(ref Label text, ref double result)
    {
        result = (int)Math.Pow(result,2);
        text.Text = result.ToString();
    }
    public static void MinorPlus(ref Label text, ref double result)
    {
        result = -result;
        text.Text = result.ToString();
    }
    public static void Pi(ref Label text, ref double result)
    {
        result = Math.PI;
        text.Text = result.ToString();
    }
    public static void E(ref Label text, ref double result)
    {
        result = Math.E;
        text.Text = result.ToString();
    }
    public static void Abs(ref Label text, ref double result)
    {
        if(result<0)
        {
            result = -result;
        }
        text.Text = result.ToString();
    }
    public static void Fac(ref Label text, ref double result,ref int ress)
    {
        ress = 1;
        for (int i = (int)result; i > 0; i--)
            ress *= i;
        result = ress;
        text.Text = result.ToString();
    }
    public static void OneX(ref Label text, ref double result)
    {
        result = 1 / result;
        text.Text = result.ToString();
    }
}
