using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Calculator : Form
    {
        //variables which are being used
        string valFirst = "";
        string valSecond = "";
        
        string arithOperator;
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtResult.Text = txtResult.Text + button.Text;
        }

        private void operators_Click(object sender, EventArgs e)
        {
            valOne = txtResult.Text;
            Button button = (Button)sender;
            ArithOperator = button.Text;
            txtResult.Clear();
            CalCulateResult();

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            valTwo = txtResult.Text;
            CalCulateResult();
            txtResult.Text = result;
        }

        private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Want to close Calculator?", "Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //Auto Cancel
            }
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        string  CalCulateResult()
        {
            switch (ArithOperator)
            {
                case "+":
                    result = (Int32.Parse(valOne) + Int32.Parse(valTwo)).ToString();
                    break;
                case "-":
                    result = (Int32.Parse(valOne) - Int32.Parse(valTwo)).ToString();
                    break;
                case "*":
                    result = (Int32.Parse(valOne) * Int32.Parse(valTwo)).ToString();
                    break;
                case "/":
                    if (txtResult.Text != "0")
                    {
                        result = (Int32.Parse(valOne) / Int32.Parse(valTwo)).ToString();
                    }
                    else
                    {
                        txtResult.Clear();
                        MessageBox.Show("Cannot Divide by Zero", "Divide by Zero Error");
                    }
                    break;
            }
            return result;
        }

        private void numberButton_Click(object sender, EventArgs e)
        {

        }
    }
}
