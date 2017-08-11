namespace Assignment05_BMR_Calcualtor_App
{
    partial class BMRCalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMRCalculatorForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblAge = new System.Windows.Forms.Label();
            this.LblHeight = new System.Windows.Forms.Label();
            this.LblWeight = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnMatrix = new System.Windows.Forms.RadioButton();
            this.rbtnImperical = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 391);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(280, 35);
            this.textBox1.TabIndex = 0;
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.BackColor = System.Drawing.Color.Transparent;
            this.LblAge.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblAge.Location = new System.Drawing.Point(23, 99);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(62, 29);
            this.LblAge.TabIndex = 1;
            this.LblAge.Text = "Age:";
            this.LblAge.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblHeight
            // 
            this.LblHeight.AutoSize = true;
            this.LblHeight.BackColor = System.Drawing.Color.Transparent;
            this.LblHeight.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblHeight.Location = new System.Drawing.Point(23, 142);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(89, 29);
            this.LblHeight.TabIndex = 1;
            this.LblHeight.Text = "Height:";
            this.LblHeight.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblWeight
            // 
            this.LblWeight.AutoSize = true;
            this.LblWeight.BackColor = System.Drawing.Color.Transparent;
            this.LblWeight.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblWeight.Location = new System.Drawing.Point(23, 188);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(94, 29);
            this.LblWeight.TabIndex = 1;
            this.LblWeight.Text = "Weight:";
            this.LblWeight.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(165, 99);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 31);
            this.txtAge.TabIndex = 2;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(165, 142);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 31);
            this.txtHeight.TabIndex = 2;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(165, 188);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 31);
            this.txtWeight.TabIndex = 3;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.BackColor = System.Drawing.Color.Transparent;
            this.rbtnMale.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rbtnMale.Location = new System.Drawing.Point(29, 234);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(84, 33);
            this.rbtnMale.TabIndex = 4;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = false;
            this.rbtnMale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.BackColor = System.Drawing.Color.Transparent;
            this.rbtnFemale.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rbtnFemale.Location = new System.Drawing.Point(165, 234);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(113, 33);
            this.rbtnFemale.TabIndex = 5;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalculate.BackgroundImage")));
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCalculate.Location = new System.Drawing.Point(12, 299);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(146, 40);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReset.Location = new System.Drawing.Point(181, 299);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 40);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.rbtnMatrix);
            this.panel1.Controls.Add(this.rbtnImperical);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 41);
            this.panel1.TabIndex = 8;
            // 
            // rbtnMatrix
            // 
            this.rbtnMatrix.AutoSize = true;
            this.rbtnMatrix.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMatrix.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbtnMatrix.Location = new System.Drawing.Point(193, 11);
            this.rbtnMatrix.Name = "rbtnMatrix";
            this.rbtnMatrix.Size = new System.Drawing.Size(67, 23);
            this.rbtnMatrix.TabIndex = 1;
            this.rbtnMatrix.TabStop = true;
            this.rbtnMatrix.Text = "Matrix";
            this.rbtnMatrix.UseVisualStyleBackColor = true;
            // 
            // rbtnImperical
            // 
            this.rbtnImperical.AutoSize = true;
            this.rbtnImperical.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnImperical.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbtnImperical.Location = new System.Drawing.Point(35, 11);
            this.rbtnImperical.Name = "rbtnImperical";
            this.rbtnImperical.Size = new System.Drawing.Size(83, 23);
            this.rbtnImperical.TabIndex = 0;
            this.rbtnImperical.TabStop = true;
            this.rbtnImperical.Text = "Imperical";
            this.rbtnImperical.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblResult.Location = new System.Drawing.Point(12, 372);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(101, 16);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Your BMR Is :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Aqua;
            this.lblTitle.Location = new System.Drawing.Point(61, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 29);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "BMR Calculator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BMRCalculatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.LblWeight);
            this.Controls.Add(this.LblHeight);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BMRCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMR Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.Label LblWeight;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnMatrix;
        private System.Windows.Forms.RadioButton rbtnImperical;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTitle;
    }
}

