using System;
using System.Windows.Forms;

namespace Simple_Calculator
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
                txtResult.Text = first;
            }
            else
            {
                second += button.Text;
                txtResult.Text = second;
            }
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
            reset();
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

        private void reset()
        {
            first = "";
            second = "";
            operation = "";
        }
    }
}
