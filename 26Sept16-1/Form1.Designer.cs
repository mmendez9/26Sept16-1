namespace _26Sept16_1
{
    partial class Form1
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
            this.Exam1 = new System.Windows.Forms.TextBox();
            this.Exam2 = new System.Windows.Forms.TextBox();
            this.tbxAverage = new System.Windows.Forms.TextBox();
            this.btmCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exam1
            // 
            this.Exam1.Location = new System.Drawing.Point(83, 13);
            this.Exam1.Name = "Exam1";
            this.Exam1.Size = new System.Drawing.Size(100, 20);
            this.Exam1.TabIndex = 0;
            // 
            // Exam2
            // 
            this.Exam2.Location = new System.Drawing.Point(83, 53);
            this.Exam2.Name = "Exam2";
            this.Exam2.Size = new System.Drawing.Size(100, 20);
            this.Exam2.TabIndex = 1;
            // 
            // tbxAverage
            // 
            this.tbxAverage.Enabled = false;
            this.tbxAverage.Location = new System.Drawing.Point(83, 146);
            this.tbxAverage.Name = "tbxAverage";
            this.tbxAverage.Size = new System.Drawing.Size(100, 20);
            this.tbxAverage.TabIndex = 2;
            // 
            // btmCalculate
            // 
            this.btmCalculate.Location = new System.Drawing.Point(96, 89);
            this.btmCalculate.Name = "btmCalculate";
            this.btmCalculate.Size = new System.Drawing.Size(76, 37);
            this.btmCalculate.TabIndex = 3;
            this.btmCalculate.Text = "Calculate Average";
            this.btmCalculate.UseVisualStyleBackColor = true;
            this.btmCalculate.Click += new System.EventHandler(this.btmCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Exam 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Exam 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Average";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmCalculate);
            this.Controls.Add(this.tbxAverage);
            this.Controls.Add(this.Exam2);
            this.Controls.Add(this.Exam1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Exam1;
        private System.Windows.Forms.TextBox Exam2;
        private System.Windows.Forms.TextBox tbxAverage;
        private System.Windows.Forms.Button btmCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

