namespace Hoteel
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
            label6 = new Label();
            txtGuestName = new TextBox();
            txtGuestAge = new TextBox();
            txtNumberOfNights = new TextBox();
            txtNumberOfGuests = new TextBox();
            label7 = new Label();
            rbStandard = new RadioButton();
            rbNormal = new RadioButton();
            rbHigh = new RadioButton();
            label8 = new Label();
            chkBreakfast = new CheckBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DodgerBlue;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, -6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(765, 86);
            label1.TabIndex = 0;
            label1.Text = "Hoteel Room Booking System";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(88, 89);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(245, 30);
            label2.TabIndex = 1;
            label2.Text = "Personal Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 136);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 2;
            label3.Text = "Guest Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 188);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 28);
            label4.TabIndex = 3;
            label4.Text = "Guest Age:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(174, 251);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(200, 28);
            label5.TabIndex = 4;
            label5.Text = "Number Of Nights:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(174, 323);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(192, 28);
            label6.TabIndex = 5;
            label6.Text = "Number Of Guest:";
            // 
            // txtGuestName
            // 
            txtGuestName.Location = new Point(407, 129);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.Size = new Size(285, 35);
            txtGuestName.TabIndex = 6;
            // 
            // txtGuestAge
            // 
            txtGuestAge.Location = new Point(407, 188);
            txtGuestAge.Name = "txtGuestAge";
            txtGuestAge.Size = new Size(285, 35);
            txtGuestAge.TabIndex = 7;
            txtGuestAge.TextChanged += textBox2_TextChanged;
            // 
            // txtNumberOfNights
            // 
            txtNumberOfNights.Location = new Point(407, 251);
            txtNumberOfNights.Name = "txtNumberOfNights";
            txtNumberOfNights.Size = new Size(285, 35);
            txtNumberOfNights.TabIndex = 8;
            txtNumberOfNights.TextChanged += textBox3_TextChanged;
            // 
            // txtNumberOfGuests
            // 
            txtNumberOfGuests.Location = new Point(407, 323);
            txtNumberOfGuests.Name = "txtNumberOfGuests";
            txtNumberOfGuests.Size = new Size(285, 35);
            txtNumberOfGuests.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(118, 387);
            label7.Name = "label7";
            label7.Size = new Size(125, 28);
            label7.TabIndex = 10;
            label7.Text = "Room Type";
            // 
            // rbStandard
            // 
            rbStandard.AutoSize = true;
            rbStandard.Location = new Point(156, 431);
            rbStandard.Name = "rbStandard";
            rbStandard.Size = new Size(126, 32);
            rbStandard.TabIndex = 11;
            rbStandard.TabStop = true;
            rbStandard.Text = "Standard";
            rbStandard.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            rbNormal.AutoSize = true;
            rbNormal.Location = new Point(379, 431);
            rbNormal.Name = "rbNormal";
            rbNormal.Size = new Size(111, 32);
            rbNormal.TabIndex = 12;
            rbNormal.TabStop = true;
            rbNormal.Text = "Normal";
            rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbHigh
            // 
            rbHigh.AutoSize = true;
            rbHigh.Location = new Point(599, 431);
            rbHigh.Name = "rbHigh";
            rbHigh.Size = new Size(84, 32);
            rbHigh.TabIndex = 13;
            rbHigh.TabStop = true;
            rbHigh.Text = "High";
            rbHigh.UseVisualStyleBackColor = true;
            rbHigh.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(112, 498);
            label8.Name = "label8";
            label8.Size = new Size(200, 28);
            label8.TabIndex = 14;
            label8.Text = "Additional Options";
            // 
            // chkBreakfast
            // 
            chkBreakfast.AutoSize = true;
            chkBreakfast.Location = new Point(125, 545);
            chkBreakfast.Name = "chkBreakfast";
            chkBreakfast.Size = new Size(366, 32);
            chkBreakfast.TabIndex = 15;
            chkBreakfast.Text = "Breakfast (10 per guest per night";
            chkBreakfast.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(131, 615);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 16;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(332, 615);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(542, 615);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 18;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(968, 20);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(291, 620);
            listBox1.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1598, 758);
            Controls.Add(listBox1);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(chkBreakfast);
            Controls.Add(label8);
            Controls.Add(rbHigh);
            Controls.Add(rbNormal);
            Controls.Add(rbStandard);
            Controls.Add(label7);
            Controls.Add(txtNumberOfGuests);
            Controls.Add(txtNumberOfNights);
            Controls.Add(txtGuestAge);
            Controls.Add(txtGuestName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtGuestName;
        private TextBox txtGuestAge;
        private TextBox txtNumberOfNights;
        private TextBox txtNumberOfGuests;
        private Label label7;
        private RadioButton rbStandard;
        private RadioButton rbNormal;
        private RadioButton rbHigh;
        private Label label8;
        private CheckBox chkBreakfast;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private ListBox listBox1;
    }
}
