using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Calculator : Form
    {
        //variables which are being used
        string first = "";
        string second = "";
        string operation = "";
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            first += button.Text;
        }

        private void operators_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            int result = 0;
            result = calculateResult();
            txtResult.Text = result.ToString();
            first = "";
        }


        private int calculateResult()
        {
            int result = 0;
            switch (operation)
            {
                case "+":
                    result = (Int32.Parse(first) + Int32.Parse(second));
                    break;
                case "-":
                    result = (Int32.Parse(first) - Int32.Parse(second));
                    break;
                case "*":
                    result = (Int32.Parse(first) * Int32.Parse(second));
                    break;
                case "/":
                    result = (Int32.Parse(first) / Int32.Parse(second));
                    break;

            }
            return result;
        }

    }
}
