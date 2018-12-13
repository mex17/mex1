namespace WindowsFormsApplication4
{
    partial class CALCULATOR
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
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.textBox1num1 = new System.Windows.Forms.TextBox();
            this.textBox2num2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addtion = new System.Windows.Forms.Button();
            this.substraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(273, 9);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(33, 13);
            this.num1.TabIndex = 0;
            this.num1.Text = "num1";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(273, 35);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(33, 13);
            this.num2.TabIndex = 1;
            this.num2.Text = "num2";
            // 
            // textBox1num1
            // 
            this.textBox1num1.Location = new System.Drawing.Point(326, 2);
            this.textBox1num1.Name = "textBox1num1";
            this.textBox1num1.Size = new System.Drawing.Size(100, 20);
            this.textBox1num1.TabIndex = 2;
            this.textBox1num1.TextChanged += new System.EventHandler(this.textBox1num1_TextChanged);
            // 
            // textBox2num2
            // 
            this.textBox2num2.Location = new System.Drawing.Point(326, 28);
            this.textBox2num2.Name = "textBox2num2";
            this.textBox2num2.Size = new System.Drawing.Size(100, 20);
            this.textBox2num2.TabIndex = 3;
            this.textBox2num2.TextChanged += new System.EventHandler(this.textBox2num2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.division);
            this.groupBox1.Controls.Add(this.multiplication);
            this.groupBox1.Controls.Add(this.substraction);
            this.groupBox1.Controls.Add(this.addtion);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(230, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENU";
            // 
            // addtion
            // 
            this.addtion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtion.Location = new System.Drawing.Point(7, 20);
            this.addtion.Name = "addtion";
            this.addtion.Size = new System.Drawing.Size(75, 37);
            this.addtion.TabIndex = 0;
            this.addtion.Text = "+";
            this.addtion.UseVisualStyleBackColor = true;
            this.addtion.Click += new System.EventHandler(this.addtion_Click);
            // 
            // substraction
            // 
            this.substraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.substraction.Location = new System.Drawing.Point(120, 19);
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(75, 38);
            this.substraction.TabIndex = 1;
            this.substraction.Text = "-";
            this.substraction.UseVisualStyleBackColor = true;
            this.substraction.Click += new System.EventHandler(this.substraction_Click);
            // 
            // multiplication
            // 
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplication.Location = new System.Drawing.Point(7, 73);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(75, 40);
            this.multiplication.TabIndex = 2;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(120, 73);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 40);
            this.division.TabIndex = 3;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "output";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(337, 222);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 6;
            // 
            // CALCULATOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(427, 359);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2num2);
            this.Controls.Add(this.textBox1num1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "CALCULATOR";
            this.Text = "CALCULATOR";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.TextBox textBox1num1;
        private System.Windows.Forms.TextBox textBox2num2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button substraction;
        private System.Windows.Forms.Button addtion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox result;
    }
}

