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
            first = txtResult.Text;
            Button button = (Button)sender;
            operation = button.Text;
            txtResult.Clear();
            calculateResult();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            second = txtResult.Text;
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
