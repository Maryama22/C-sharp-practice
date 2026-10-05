namespace Range_Checker
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
            txtInput = new TextBox();
            label3 = new Label();
            lblDecision = new Label();
            btnCheck = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(304, 30);
            label1.TabIndex = 0;
            label1.Text = "Range Checker Application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(250, 123);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(493, 30);
            label2.TabIndex = 1;
            label2.Text = "Enter an integer in the range of 1 through 10";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(498, 197);
            txtInput.Margin = new Padding(4, 3, 4, 3);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(290, 35);
            txtInput.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(554, 274);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(164, 28);
            label3.TabIndex = 3;
            label3.Text = "Range Decision";
            // 
            // lblDecision
            // 
            lblDecision.BorderStyle = BorderStyle.FixedSingle;
            lblDecision.Location = new Point(250, 328);
            lblDecision.Margin = new Padding(4, 0, 4, 0);
            lblDecision.Name = "lblDecision";
            lblDecision.Size = new Size(640, 49);
            lblDecision.TabIndex = 4;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.Location = new Point(396, 465);
            btnCheck.Margin = new Padding(4, 3, 4, 3);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(212, 80);
            btnCheck.TabIndex = 5;
            btnCheck.Text = "Check Qualification";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(644, 486);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(144, 48);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(826, 486);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(144, 45);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1502, 755);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCheck);
            Controls.Add(lblDecision);
            Controls.Add(label3);
            Controls.Add(txtInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Range_Checker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtInput;
        private Label label3;
        private Label lblDecision;
        private Button btnCheck;
        private Button btnClear;
        private Button btnExit;
    }
}
