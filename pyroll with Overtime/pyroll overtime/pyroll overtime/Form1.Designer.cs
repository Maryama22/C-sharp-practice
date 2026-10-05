namespace pyroll_overtime
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
            hoursWorkedTextBox = new TextBox();
            hourlyPayRateTextBox = new TextBox();
            grossPayLabel = new Label();
            CalculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 111);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 0;
            label1.Text = "Hours Worked:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 187);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 1;
            label2.Text = "Hourly pay rate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 278);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 28);
            label3.TabIndex = 2;
            label3.Text = "Gross pay:";
            // 
            // hoursWorkedTextBox
            // 
            hoursWorkedTextBox.Location = new Point(562, 111);
            hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            hoursWorkedTextBox.Size = new Size(201, 35);
            hoursWorkedTextBox.TabIndex = 3;
            hoursWorkedTextBox.TextChanged += textBox1_TextChanged;
            // 
            // hourlyPayRateTextBox
            // 
            hourlyPayRateTextBox.Location = new Point(562, 184);
            hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            hourlyPayRateTextBox.Size = new Size(201, 35);
            hourlyPayRateTextBox.TabIndex = 4;
            // 
            // grossPayLabel
            // 
            grossPayLabel.BorderStyle = BorderStyle.FixedSingle;
            grossPayLabel.Location = new Point(562, 268);
            grossPayLabel.Name = "grossPayLabel";
            grossPayLabel.Size = new Size(201, 38);
            grossPayLabel.TabIndex = 5;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(265, 411);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(206, 64);
            CalculateButton.TabIndex = 6;
            CalculateButton.Text = "Calculate Gross Pay";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(508, 426);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(117, 49);
            clearButton.TabIndex = 7;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(651, 426);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 49);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1617, 739);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(CalculateButton);
            Controls.Add(grossPayLabel);
            Controls.Add(hourlyPayRateTextBox);
            Controls.Add(hoursWorkedTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Payroll with Overtime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox hoursWorkedTextBox;
        private TextBox hourlyPayRateTextBox;
        private Label grossPayLabel;
        private Button CalculateButton;
        private Button clearButton;
        private Button exitButton;
    }
}
