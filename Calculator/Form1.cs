namespace Calculator
{
    public partial class Form1 : Form
    {
        public int position = 0;
        public double result = 0;
        public int result2 = 0;
        public string events = "";
        public bool isdelete = false;
        public int ress = 1;
        public Form1()
        {
            InitializeComponent();
            //add Color var for buttons
            this.BackColor = Color.FromArgb(102, 153, 204);
            bC.BackColor = Color.FromArgb(197, 216, 109);
            bClear.BackColor = Color.FromArgb(197, 216, 109);
            bDivide.BackColor = Color.FromArgb(51, 30, 56);
            bPluss.BackColor = Color.FromArgb(51, 30, 56);
            bMinus.BackColor = Color.FromArgb(51, 30, 56);
            bMultiply.BackColor = Color.FromArgb(51, 30, 56);
            bMultiply.BackColor = Color.FromArgb(51, 30, 56);
            bMinorPlus.BackColor = Color.FromArgb(51, 30, 56);
            
            
            bEquals.BackColor = Color.FromArgb(197, 216, 109);
            bvalue1.BackColor = Color.FromArgb(112, 160, 175);
            bvalue2.BackColor = Color.FromArgb(112, 160, 175);
            bvalue3.BackColor = Color.FromArgb(112, 160, 175);
            bvalue4.BackColor = Color.FromArgb(112, 160, 175);
            bvalue5.BackColor = Color.FromArgb(112, 160, 175);
            bvalue6.BackColor = Color.FromArgb(112, 160, 175);
            bvalue7.BackColor = Color.FromArgb(112, 160, 175);
            bvalue8.BackColor = Color.FromArgb(112, 160, 175);
            bvalue9.BackColor = Color.FromArgb(112, 160, 175);
            bvalue0.BackColor = Color.FromArgb(112, 160, 175);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void bvalue0_Click(object sender, EventArgs e)
        {
            int value = 0;
            //1)не повинно передаватися більше 3х параметрів 
            //2) не повинні передавати за посиланям
            CalculatorLogic.AdNumber(value, ref position, ref lvalue, ref result, ref isdelete, ref laction);
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
            CalculatorLogic.DeleteAll(ref position, ref lvalue, ref result, ref laction);
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
            CalculatorLogic.Plus(ref lvalue, ref result, ref laction, ref events, ref result2);
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

        private void bP_Click(object sender, EventArgs e)
        {
            CalculatorLogic.Pi(ref lvalue, ref result);
        }

        private void bE_Click(object sender, EventArgs e)
        {
            CalculatorLogic.E(ref lvalue, ref result);
        }
        private void bAbs_Click(object sender, EventArgs e)
        {
            CalculatorLogic.Abs(ref lvalue, ref result);
        }

        private void bFac_Click(object sender, EventArgs e)
        {

            CalculatorLogic.Fac(ref lvalue, ref result, ref ress);
        }

        private void bonex_Click(object sender, EventArgs e)
        {
            CalculatorLogic.OneX(ref lvalue, ref result);
        }
    }
}
