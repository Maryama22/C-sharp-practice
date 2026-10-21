namespace Home_Assigment
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
            dateOutputLabel = new Label();
            dayOfWeekLabel = new Label();
            monthlabel = new Label();
            dayOfmonthlabel = new Label();
            yearpromt = new Label();
            dayOfWeekTextBox = new TextBox();
            dayOfMonthTextBox = new TextBox();
            monthTextBox = new TextBox();
            yearTextBox = new TextBox();
            showDateButton = new Button();
            ClearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // dateOutputLabel
            // 
            dateOutputLabel.BorderStyle = BorderStyle.FixedSingle;
            dateOutputLabel.Location = new Point(129, 451);
            dateOutputLabel.Margin = new Padding(4, 0, 4, 0);
            dateOutputLabel.Name = "dateOutputLabel";
            dateOutputLabel.Size = new Size(1093, 96);
            dateOutputLabel.TabIndex = 0;
            dateOutputLabel.Click += label1_Click_1;
            // 
            // dayOfWeekLabel
            // 
            dayOfWeekLabel.AutoSize = true;
            dayOfWeekLabel.Location = new Point(429, 135);
            dayOfWeekLabel.Margin = new Padding(4, 0, 4, 0);
            dayOfWeekLabel.Name = "dayOfWeekLabel";
            dayOfWeekLabel.Size = new Size(288, 30);
            dayOfWeekLabel.TabIndex = 1;
            dayOfWeekLabel.Text = "Enter the day of the week";
            // 
            // monthlabel
            // 
            monthlabel.AutoSize = true;
            monthlabel.Location = new Point(434, 216);
            monthlabel.Margin = new Padding(4, 0, 4, 0);
            monthlabel.Name = "monthlabel";
            monthlabel.Size = new Size(283, 30);
            monthlabel.TabIndex = 2;
            monthlabel.Text = "Enter the name of month";
            monthlabel.Click += monthlabel_Click;
            // 
            // dayOfmonthlabel
            // 
            dayOfmonthlabel.AutoSize = true;
            dayOfmonthlabel.Location = new Point(353, 296);
            dayOfmonthlabel.Margin = new Padding(4, 0, 4, 0);
            dayOfmonthlabel.Name = "dayOfmonthlabel";
            dayOfmonthlabel.Size = new Size(403, 30);
            dayOfmonthlabel.TabIndex = 3;
            dayOfmonthlabel.Text = "Enter the Numeric day of the month";
            // 
            // yearpromt
            // 
            yearpromt.AutoSize = true;
            yearpromt.Location = new Point(489, 392);
            yearpromt.Margin = new Padding(4, 0, 4, 0);
            yearpromt.Name = "yearpromt";
            yearpromt.Size = new Size(164, 30);
            yearpromt.TabIndex = 4;
            yearpromt.Text = "Enter the year";
            yearpromt.Click += yearpromt_Click;
            // 
            // dayOfWeekTextBox
            // 
            dayOfWeekTextBox.BorderStyle = BorderStyle.FixedSingle;
            dayOfWeekTextBox.Location = new Point(774, 128);
            dayOfWeekTextBox.Margin = new Padding(4);
            dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            dayOfWeekTextBox.Size = new Size(318, 37);
            dayOfWeekTextBox.TabIndex = 5;
            // 
            // dayOfMonthTextBox
            // 
            dayOfMonthTextBox.BorderStyle = BorderStyle.FixedSingle;
            dayOfMonthTextBox.Location = new Point(774, 289);
            dayOfMonthTextBox.Margin = new Padding(4);
            dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            dayOfMonthTextBox.Size = new Size(318, 37);
            dayOfMonthTextBox.TabIndex = 6;
            // 
            // monthTextBox
            // 
            monthTextBox.BorderStyle = BorderStyle.FixedSingle;
            monthTextBox.Location = new Point(774, 209);
            monthTextBox.Margin = new Padding(4);
            monthTextBox.Name = "monthTextBox";
            monthTextBox.Size = new Size(318, 37);
            monthTextBox.TabIndex = 7;
            // 
            // yearTextBox
            // 
            yearTextBox.BorderStyle = BorderStyle.FixedSingle;
            yearTextBox.Location = new Point(774, 385);
            yearTextBox.Margin = new Padding(4);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(318, 37);
            yearTextBox.TabIndex = 8;
            yearTextBox.TextChanged += textBox4_TextChanged;
            // 
            // showDateButton
            // 
            showDateButton.BackColor = SystemColors.ButtonFace;
            showDateButton.Location = new Point(313, 573);
            showDateButton.Name = "showDateButton";
            showDateButton.Size = new Size(172, 34);
            showDateButton.TabIndex = 9;
            showDateButton.Text = "Show Date";
            showDateButton.UseVisualStyleBackColor = false;
            showDateButton.Click += showDateButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(573, 573);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 34);
            ClearButton.TabIndex = 10;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(783, 573);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(136, 34);
            exitButton.TabIndex = 11;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1404, 764);
            Controls.Add(exitButton);
            Controls.Add(ClearButton);
            Controls.Add(showDateButton);
            Controls.Add(yearTextBox);
            Controls.Add(monthTextBox);
            Controls.Add(dayOfMonthTextBox);
            Controls.Add(dayOfWeekTextBox);
            Controls.Add(yearpromt);
            Controls.Add(dayOfmonthlabel);
            Controls.Add(monthlabel);
            Controls.Add(dayOfWeekLabel);
            Controls.Add(dateOutputLabel);
            Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Birth Date String";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dateOutputLabel;
        private Label dayOfWeekLabel;
        private Label monthlabel;
        private Label dayOfmonthlabel;
        private Label yearpromt;
        private TextBox dayOfWeekTextBox;
        private TextBox dayOfMonthTextBox;
        private TextBox monthTextBox;
        private TextBox yearTextBox;
        private Button showDateButton;
        private Button ClearButton;
        private Button exitButton;
    }
}
