using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        string first;
        string second;
        string operation;
        public Calculator()
        {
            InitializeComponent();
            reset();
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (operation == "")
            {
                first += button.Text;
                txtResult.Text = first.ToString();
            }
            else
            {
                second += button.Text;
                txtResult.Text = second.ToString();
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (operation == "")
            {
                operation = button.Text;
            }
            else
            {
                callEqual();
            }
            
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            callEqual();
        }

        private int calculateResult()
        {
            int result = 0;
            switch (operation)
            {
                case "+":
                    result = Int32.Parse(first) + Int32.Parse(second);
                    break;
                case "-":
                    result = Int32.Parse(first) - Int32.Parse(second);
                    break;
                case "*":
                    result = Int32.Parse(first) * Int32.Parse(second);
                    break;
                case "/":
                    result = Int32.Parse(first) / Int32.Parse(second);
                    break;
            }
            return result;
        }

        private void reset()
        {
            first = "";
            second = "";
            operation = "";
        }
        private void callEqual()
        {
            int result;
            result = calculateResult();
            txtResult.Text = result.ToString();
            reset();
            first = result.ToString();
        }
    }
}
