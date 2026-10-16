namespace Assigment
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
            DisplayLabel = new Label();
            StudentTextBox = new TextBox();
            StudentIDTextBox = new TextBox();
            NumberTextBox = new TextBox();
            StudyTextBox = new TextBox();
            TransportTextBox = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label1.Location = new Point(114, 67);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 0;
            label1.Text = "Student Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label2.Location = new Point(114, 140);
            label2.Name = "label2";
            label2.Size = new Size(147, 32);
            label2.TabIndex = 1;
            label2.Text = "Student ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label3.Location = new Point(114, 212);
            label3.Name = "label3";
            label3.Size = new Size(236, 32);
            label3.TabIndex = 2;
            label3.Text = "Number of Course:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label4.Location = new Point(114, 296);
            label4.Name = "label4";
            label4.Size = new Size(151, 32);
            label4.TabIndex = 3;
            label4.Text = "Study level:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label5.Location = new Point(114, 367);
            label5.Name = "label5";
            label5.Size = new Size(224, 32);
            label5.TabIndex = 4;
            label5.Text = "Transport Option:";
            // 
            // DisplayLabel
            // 
            DisplayLabel.BorderStyle = BorderStyle.FixedSingle;
            DisplayLabel.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DisplayLabel.Location = new Point(56, 399);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(855, 201);
            DisplayLabel.TabIndex = 5;
            // 
            // StudentTextBox
            // 
            StudentTextBox.Location = new Point(494, 81);
            StudentTextBox.Name = "StudentTextBox";
            StudentTextBox.Size = new Size(290, 31);
            StudentTextBox.TabIndex = 6;
            // 
            // StudentIDTextBox
            // 
            StudentIDTextBox.Location = new Point(494, 145);
            StudentIDTextBox.Name = "StudentIDTextBox";
            StudentIDTextBox.Size = new Size(290, 31);
            StudentIDTextBox.TabIndex = 7;
            // 
            // NumberTextBox
            // 
            NumberTextBox.Location = new Point(494, 214);
            NumberTextBox.Name = "NumberTextBox";
            NumberTextBox.Size = new Size(290, 31);
            NumberTextBox.TabIndex = 8;
            // 
            // StudyTextBox
            // 
            StudyTextBox.Location = new Point(494, 299);
            StudyTextBox.Name = "StudyTextBox";
            StudyTextBox.Size = new Size(290, 31);
            StudyTextBox.TabIndex = 9;
            // 
            // TransportTextBox
            // 
            TransportTextBox.Location = new Point(494, 372);
            TransportTextBox.Name = "TransportTextBox";
            TransportTextBox.Size = new Size(290, 31);
            TransportTextBox.TabIndex = 10;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Green;
            btnCalculate.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(114, 603);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(147, 53);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gold;
            btnClear.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(327, 603);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(146, 53);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(534, 603);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(160, 54);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(158, 13);
            label7.Name = "label7";
            label7.Size = new Size(274, 30);
            label7.TabIndex = 14;
            label7.Text = "Registration Fee System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 654);
            Controls.Add(label7);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(TransportTextBox);
            Controls.Add(StudyTextBox);
            Controls.Add(NumberTextBox);
            Controls.Add(StudentIDTextBox);
            Controls.Add(StudentTextBox);
            Controls.Add(DisplayLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label DisplayLabel;
        private TextBox StudentTextBox;
        private TextBox StudentIDTextBox;
        private TextBox NumberTextBox;
        private TextBox StudyTextBox;
        private TextBox TransportTextBox;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label label7;
    }
}
