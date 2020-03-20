namespace Simple_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearLbl = new System.Windows.Forms.Button();
            this.lblTempResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.btnClearLbl);
            this.groupBox1.Controls.Add(this.lblTempResult);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.btnDiv);
            this.groupBox1.Controls.Add(this.btnNine);
            this.groupBox1.Controls.Add(this.btnSub);
            this.groupBox1.Controls.Add(this.btnFour);
            this.groupBox1.Controls.Add(this.btnFive);
            this.groupBox1.Controls.Add(this.btnThree);
            this.groupBox1.Controls.Add(this.btnMul);
            this.groupBox1.Controls.Add(this.btnSeven);
            this.groupBox1.Controls.Add(this.btnEight);
            this.groupBox1.Controls.Add(this.btnSix);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnOne);
            this.groupBox1.Controls.Add(this.btnTwo);
            this.groupBox1.Controls.Add(this.btnEqual);
            this.groupBox1.Controls.Add(this.btnZero);
            this.groupBox1.Location = new System.Drawing.Point(6, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 355);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnClearLbl
            // 
            this.btnClearLbl.BackColor = System.Drawing.Color.Gray;
            this.btnClearLbl.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLbl.Location = new System.Drawing.Point(270, 13);
            this.btnClearLbl.Name = "btnClearLbl";
            this.btnClearLbl.Size = new System.Drawing.Size(75, 33);
            this.btnClearLbl.TabIndex = 3;
            this.btnClearLbl.Text = "←";
            this.btnClearLbl.UseVisualStyleBackColor = false;
            this.btnClearLbl.Click += new System.EventHandler(this.btnClearLbl_Click);
            // 
            // lblTempResult
            // 
            this.lblTempResult.AutoSize = true;
            this.lblTempResult.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempResult.Location = new System.Drawing.Point(15, 24);
            this.lblTempResult.Name = "lblTempResult";
            this.lblTempResult.Size = new System.Drawing.Size(0, 22);
            this.lblTempResult.TabIndex = 2;
            this.lblTempResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtResult.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(7, 49);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(338, 73);
            this.txtResult.TabIndex = 1;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.DimGray;
            this.btnDiv.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(265, 128);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(80, 50);
            this.btnDiv.TabIndex = 0;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.operators_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.DimGray;
            this.btnNine.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(179, 128);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(80, 50);
            this.btnNine.TabIndex = 0;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.button_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.DimGray;
            this.btnSub.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(265, 240);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(80, 50);
            this.btnSub.TabIndex = 0;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.operators_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.DimGray;
            this.btnFour.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(7, 184);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(80, 50);
            this.btnFour.TabIndex = 0;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.button_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.DimGray;
            this.btnFive.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(93, 184);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(80, 50);
            this.btnFive.TabIndex = 0;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.button_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.DimGray;
            this.btnThree.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(179, 240);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(80, 50);
            this.btnThree.TabIndex = 0;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.button_Click);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.Color.DimGray;
            this.btnMul.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.Location = new System.Drawing.Point(265, 184);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(80, 50);
            this.btnMul.TabIndex = 0;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.operators_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.DimGray;
            this.btnSeven.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(7, 128);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(80, 50);
            this.btnSeven.TabIndex = 0;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.button_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.DimGray;
            this.btnEight.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(93, 128);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(80, 50);
            this.btnEight.TabIndex = 0;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.button_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.DimGray;
            this.btnSix.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(179, 184);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(80, 50);
            this.btnSix.TabIndex = 0;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.button_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(265, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.operators_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.DimGray;
            this.btnOne.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(7, 240);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(80, 50);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.button_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.DimGray;
            this.btnTwo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(93, 240);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(80, 50);
            this.btnTwo.TabIndex = 0;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.button_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.DimGray;
            this.btnEqual.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(179, 296);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(80, 50);
            this.btnEqual.TabIndex = 0;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.DimGray;
            this.btnZero.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(7, 296);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(166, 50);
            this.btnZero.TabIndex = 0;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.button_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Gray;
            this.btnHistory.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(4, 2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(87, 33);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(364, 396);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calculator_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblTempResult;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnClearLbl;
        private System.Windows.Forms.Button btnHistory;
    }
}

