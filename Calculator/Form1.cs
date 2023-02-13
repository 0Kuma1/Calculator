namespace Calculator
{
    public partial class Form1 : Form
    {
        public int position = 0;
        public int result = 0;
        public int result2 = 0;
        public string events = "";
        public bool isdelete = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void bvalue0_Click(object sender, EventArgs e)
        {
            int value = 0;
            CalculatorLogic.AdNumber(value,ref position,ref lvalue,ref result, ref isdelete, ref laction);
            position++;
        }

        private void bvalue1_Click(object sender, EventArgs e)
        {
            int value = 1;
            CalculatorLogic.AdNumber(value, ref position, ref lvalue, ref result, ref isdelete, ref laction);
            position++;
        }

        private void bvalue2_Click(object sender, EventArgs e)
        {
            int value = 2;
            CalculatorLogic.AdNumber(value, ref position, ref lvalue, ref result, ref isdelete, ref laction);
            position++;
        }

        private void bvalue3_Click(object sender, EventArgs e)
        {
            int value = 3;
            CalculatorLogic.AdNumber(value, ref position, ref lvalue, ref result, ref isdelete, ref laction);
            position++;
        }

        private void bvalue4_Click(object sender, EventArgs e)
        {
            int value = 4;
            CalculatorLogic.AdNumber(value, ref position, ref lvalue, ref result, ref isdelete, ref laction);
            position++;
        }

        private void bvalue5_Click(object sender, EventArgs e)
        {
            int value = 5;
            CalculatorLogic.AdNumber(value, ref position, ref lvalue, ref result, ref isdelete, ref laction);
            position++;
        }

        private void bvalue6_Click(object sender, EventArgs e)
        {
            int value = 6;
            CalculatorLogic.AdNumber(value, ref position, ref lvalue, ref result, ref isdelete, ref laction);
            position++;
        }

        private void bvalue7_Click(object sender, EventArgs e)
        {
            int value = 7;
            CalculatorLogic.AdNumber(value, ref position, ref lvalue, ref result, ref isdelete, ref laction);
            position++;
        }

        private void bvalue8_Click(object sender, EventArgs e)
        {
            int value = 8;
            CalculatorLogic.AdNumber(value, ref position, ref lvalue, ref result, ref isdelete, ref laction);
            position++;
        }

        private void bvalue9_Click(object sender, EventArgs e)
        {
            int value = 9;
            CalculatorLogic.AdNumber(value, ref position, ref lvalue, ref result, ref isdelete, ref laction);
            position++;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            CalculatorLogic.DeleteNumber(ref position, ref lvalue, ref result);
        }

        private void bC_Click(object sender, EventArgs e)
        {
            CalculatorLogic.DeleteAll(ref position, ref lvalue, ref result,ref laction);
        }

        private void bDivide_Click(object sender, EventArgs e)
        {
            CalculatorLogic.Divide(ref lvalue, ref result, ref laction, ref events, ref result2);
        }

        private void bMultiply_Click(object sender, EventArgs e)
        {
            CalculatorLogic.Multiply(ref lvalue, ref result, ref laction, ref events, ref result2);
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            CalculatorLogic.Minus(ref lvalue, ref result, ref laction, ref events, ref result2);
        }

        private void bPluss_Click(object sender, EventArgs e)
        {
            CalculatorLogic.Plus(ref lvalue, ref result,ref laction,ref events, ref result2);
        }

        private void bEquals_Click(object sender, EventArgs e)
        {
            CalculatorLogic.Equals(ref lvalue, ref result, ref laction, ref events, ref result2, ref isdelete);
        }
        private void bSqrt_Click(object sender, EventArgs e)
        {
            CalculatorLogic.Sqrt(ref lvalue, ref result);
        }

        private void bPow_Click(object sender, EventArgs e)
        {
            CalculatorLogic.Poww(ref lvalue, ref result);
        }
        private void bMinorPlus_Click(object sender, EventArgs e)
        {
            CalculatorLogic.MinorPlus(ref lvalue, ref result);
        }
    }
}