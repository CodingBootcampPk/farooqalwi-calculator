using System;
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
            
            lblTempResult.Text += button.Text;
        }

        private void operators_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ArithOperator = button.Text;
            valOne = Int32.Parse(txtResult.Text);
            lblTempResult.Text += ArithOperator;
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
                    if (txtResult.Text != "0")
                    {
                        txtResult.Text = (valOne / valTwo).ToString();
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

        private void btnClearLbl_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            lblTempResult.Text = "";
        }
    }
}
