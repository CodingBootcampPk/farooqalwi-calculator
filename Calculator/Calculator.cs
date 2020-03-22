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
            if (second == "")
            {
                operation = button.Text;
            }
            else
            {
                int result = calculateResult();
                txtResult.Text = result.ToString();
                first = result.ToString();
                operation = button.Text;
                second = "";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            int result = calculateResult();
            txtResult.Text = result.ToString();
            reset();
            first = result.ToString();
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
    }
}
