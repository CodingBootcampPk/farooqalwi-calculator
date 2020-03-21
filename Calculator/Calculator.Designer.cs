namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnDivide);
            this.panel1.Controls.Add(this.btnOne);
            this.panel1.Controls.Add(this.btnEight);
            this.panel1.Controls.Add(this.btnThree);
            this.panel1.Controls.Add(this.btnSub);
            this.panel1.Controls.Add(this.btnFour);
            this.panel1.Controls.Add(this.btnTwo);
            this.panel1.Controls.Add(this.btnSix);
            this.panel1.Controls.Add(this.btnMultiply);
            this.panel1.Controls.Add(this.btnZero);
            this.panel1.Controls.Add(this.btnEqual);
            this.panel1.Controls.Add(this.btnSum);
            this.panel1.Controls.Add(this.btnFive);
            this.panel1.Controls.Add(this.btnSeven);
            this.panel1.Controls.Add(this.btnNine);
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 273);
            this.panel1.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(4, 5);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(277, 50);
            this.txtResult.TabIndex = 1;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.Control;
            this.btnDivide.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDivide.Location = new System.Drawing.Point(213, 60);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(70, 50);
            this.btnDivide.TabIndex = 2;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.SystemColors.Control;
            this.btnOne.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOne.Location = new System.Drawing.Point(3, 166);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(70, 50);
            this.btnOne.TabIndex = 3;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.number_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.SystemColors.Control;
            this.btnEight.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEight.Location = new System.Drawing.Point(73, 60);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(70, 50);
            this.btnEight.TabIndex = 4;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.number_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.SystemColors.Control;
            this.btnThree.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThree.Location = new System.Drawing.Point(143, 166);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(70, 50);
            this.btnThree.TabIndex = 5;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.number_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.SystemColors.Control;
            this.btnSub.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSub.Location = new System.Drawing.Point(213, 166);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(70, 50);
            this.btnSub.TabIndex = 6;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.SystemColors.Control;
            this.btnFour.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFour.Location = new System.Drawing.Point(3, 113);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(70, 50);
            this.btnFour.TabIndex = 7;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.number_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.SystemColors.Control;
            this.btnTwo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTwo.Location = new System.Drawing.Point(73, 166);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(70, 50);
            this.btnTwo.TabIndex = 8;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.number_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.SystemColors.Control;
            this.btnSix.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSix.Location = new System.Drawing.Point(143, 113);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(70, 50);
            this.btnSix.TabIndex = 9;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.number_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.SystemColors.Control;
            this.btnMultiply.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMultiply.Location = new System.Drawing.Point(213, 113);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(70, 50);
            this.btnMultiply.TabIndex = 10;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.Control;
            this.btnZero.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZero.Location = new System.Drawing.Point(3, 219);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(140, 50);
            this.btnZero.TabIndex = 11;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.number_Click);
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.SystemColors.Control;
            this.btnSum.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSum.Location = new System.Drawing.Point(213, 219);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(70, 50);
            this.btnSum.TabIndex = 12;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.SystemColors.Control;
            this.btnFive.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFive.Location = new System.Drawing.Point(73, 113);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(70, 50);
            this.btnFive.TabIndex = 13;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.number_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.SystemColors.Control;
            this.btnSeven.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSeven.Location = new System.Drawing.Point(3, 60);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(70, 50);
            this.btnSeven.TabIndex = 14;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.number_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.SystemColors.Control;
            this.btnNine.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNine.Location = new System.Drawing.Point(143, 60);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(70, 50);
            this.btnNine.TabIndex = 15;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.number_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.Control;
            this.btnEqual.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEqual.Location = new System.Drawing.Point(143, 219);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(70, 50);
            this.btnEqual.TabIndex = 12;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 272);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEqual;
    }
}

