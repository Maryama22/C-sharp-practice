namespace Test_Average
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtScore1 = new TextBox();
            txtScore3 = new TextBox();
            txtScore2 = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblAverage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(258, 48);
            label1.Name = "label1";
            label1.Size = new Size(256, 30);
            label1.TabIndex = 0;
            label1.Text = "Enter Three Test Score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 137);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 1;
            label2.Text = "Test Score #1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 203);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 2;
            label3.Text = "Test Score #2";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 275);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 3;
            label4.Text = "Test Score #3";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(395, 363);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 4;
            label5.Text = "Average";
            // 
            // txtScore1
            // 
            txtScore1.Location = new Point(569, 137);
            txtScore1.Name = "txtScore1";
            txtScore1.Size = new Size(213, 32);
            txtScore1.TabIndex = 5;
            txtScore1.TextChanged += textBox1_TextChanged;
            // 
            // txtScore3
            // 
            txtScore3.Location = new Point(569, 275);
            txtScore3.Name = "txtScore3";
            txtScore3.Size = new Size(213, 32);
            txtScore3.TabIndex = 6;
            // 
            // txtScore2
            // 
            txtScore2.Location = new Point(569, 203);
            txtScore2.Name = "txtScore2";
            txtScore2.Size = new Size(213, 32);
            txtScore2.TabIndex = 7;
            txtScore2.TextChanged += textBox3_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(290, 480);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(149, 88);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate Average";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(511, 480);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(511, 534);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.BottomCenter;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button3_Click;
            // 
            // lblAverage
            // 
            lblAverage.BorderStyle = BorderStyle.FixedSingle;
            lblAverage.Location = new Point(569, 350);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(213, 38);
            lblAverage.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 708);
            Controls.Add(lblAverage);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtScore2);
            Controls.Add(txtScore3);
            Controls.Add(txtScore1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Test Score Average";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtScore1;
        private TextBox txtScore3;
        private TextBox txtScore2;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label lblAverage;
    }
}
