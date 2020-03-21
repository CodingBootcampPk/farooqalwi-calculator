using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Calculator : Form
    {
        //variables which are being used
        string First = "";
        string Second = "";
        string Operator = "";
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            First += button.Text;
        }

        private void operators_Click(object sender, EventArgs e)
        {
            First = txtResult.Text;
            Button button = (Button)sender;
            Operator = button.Text;
            txtResult.Clear();
            calculateResult();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Second = txtResult.Text;
            calculateResult();
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

        private int calculateResult()
        {
            int result = 0;
            switch (Operator)
            {
                case "+":
                    result = (Int32.Parse(First) + Int32.Parse(Second));
                    break;
                case "-":
                    result = (Int32.Parse(First) - Int32.Parse(Second));
                    break;
                case "*":
                    result = (Int32.Parse(First) * Int32.Parse(Second));
                    break;
                case "/":
                    result = (Int32.Parse(First) / Int32.Parse(Second));
                    break;

            }
            return result;
        }

    }
}
