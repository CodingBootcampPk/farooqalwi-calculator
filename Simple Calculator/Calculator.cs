using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Calculator : Form
    {
        //variables which are being used
        int valOne = 0;
        int valTwo = 0;
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
            valOne = Int32.Parse(txtResult.Text);
            txtResult.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            valTwo = Int32.Parse(txtResult.Text);
            switch (ArithOperator)
            {
                case "+":
                    txtResult.Text = (valOne + valTwo).ToString();
                    break;
                case "-":
                    txtResult.Text = (valOne - valTwo).ToString();
                    break;
                case "*":
                    txtResult.Text = (valOne * valTwo).ToString();
                    break;
                case "/":
                    txtResult.Text = (valOne / valTwo).ToString();
                    break;

            }
        }
    }
}
