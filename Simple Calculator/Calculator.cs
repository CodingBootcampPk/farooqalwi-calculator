using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Calculator : Form
    {
        //variables which are being used
        string valOne = "";
        string valTwo = "";
        string ArithOperator;
        

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtResult.Text = txtResult.Text + button.Text;
            
        }

        private void operators_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ArithOperator = button.Text;
            valOne += txtResult.Text;
            txtResult.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            valTwo = txtResult.Text;
            switch (ArithOperator)
            {
                case "+":
                    txtResult.Text = (Int32.Parse(valOne) + Int32.Parse(valTwo)).ToString();
                    break;
                case "-":
                    txtResult.Text = (Int32.Parse(valOne) - Int32.Parse(valTwo)).ToString();
                    break;
                case "*":
                    txtResult.Text = (Int32.Parse(valOne) * Int32.Parse(valTwo)).ToString();
                    break;
                case "/":
                    if (txtResult.Text != "0")
                    {
                        txtResult.Text = (Int32.Parse(valOne) / Int32.Parse(valTwo)).ToString();
                    }
                    else
                    {
                        txtResult.Clear();
                        MessageBox.Show("Cannot Divide by Zero", "Divide by Zero Error");
                    }
                    break;
            }
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
    }
}
