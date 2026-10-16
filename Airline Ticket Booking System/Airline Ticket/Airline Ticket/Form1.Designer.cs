namespace Airline_Ticket
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
            txtPassengerName = new TextBox();
            txtPassengerAge = new TextBox();
            txtNumberOfTickets = new TextBox();
            txtBaggageWeight = new TextBox();
            label7 = new Label();
            rbFirstClass = new RadioButton();
            rbNormalClass = new RadioButton();
            rbBusinessClass = new RadioButton();
            label8 = new Label();
            chkTravelInsurance = new CheckBox();
            listBox1 = new ListBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(343, 32);
            label1.TabIndex = 0;
            label1.Text = "Airline Ticket Booking System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 88);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 28);
            label2.TabIndex = 1;
            label2.Text = "Passenger Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 152);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(164, 28);
            label3.TabIndex = 2;
            label3.Text = "Passenger Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 225);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(203, 28);
            label4.TabIndex = 3;
            label4.Text = "Number of Tickets:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(160, 288);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(218, 28);
            label5.TabIndex = 4;
            label5.Text = "Baggage weight(kg):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 42);
            label6.Name = "label6";
            label6.Size = new Size(225, 28);
            label6.TabIndex = 5;
            label6.Text = "Personal Information";
            // 
            // txtPassengerName
            // 
            txtPassengerName.Location = new Point(394, 88);
            txtPassengerName.Name = "txtPassengerName";
            txtPassengerName.Size = new Size(295, 35);
            txtPassengerName.TabIndex = 6;
            // 
            // txtPassengerAge
            // 
            txtPassengerAge.Location = new Point(394, 145);
            txtPassengerAge.Name = "txtPassengerAge";
            txtPassengerAge.Size = new Size(295, 35);
            txtPassengerAge.TabIndex = 7;
            txtPassengerAge.TextChanged += txtPassengerAge_TextChanged;
            // 
            // txtNumberOfTickets
            // 
            txtNumberOfTickets.Location = new Point(394, 218);
            txtNumberOfTickets.Name = "txtNumberOfTickets";
            txtNumberOfTickets.Size = new Size(295, 35);
            txtNumberOfTickets.TabIndex = 8;
            // 
            // txtBaggageWeight
            // 
            txtBaggageWeight.Location = new Point(394, 285);
            txtBaggageWeight.Name = "txtBaggageWeight";
            txtBaggageWeight.Size = new Size(295, 35);
            txtBaggageWeight.TabIndex = 9;
            txtBaggageWeight.TextChanged += txtBaggageWeight_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(61, 372);
            label7.Name = "label7";
            label7.Size = new Size(130, 28);
            label7.TabIndex = 10;
            label7.Text = "Travel Class";
            // 
            // rbFirstClass
            // 
            rbFirstClass.AutoSize = true;
            rbFirstClass.Location = new Point(100, 423);
            rbFirstClass.Name = "rbFirstClass";
            rbFirstClass.Size = new Size(137, 32);
            rbFirstClass.TabIndex = 11;
            rbFirstClass.TabStop = true;
            rbFirstClass.Text = "First Class";
            rbFirstClass.UseVisualStyleBackColor = true;
            rbFirstClass.CheckedChanged += rbFirstClass_CheckedChanged;
            // 
            // rbNormalClass
            // 
            rbNormalClass.AutoSize = true;
            rbNormalClass.Location = new Point(304, 423);
            rbNormalClass.Name = "rbNormalClass";
            rbNormalClass.Size = new Size(167, 32);
            rbNormalClass.TabIndex = 12;
            rbNormalClass.TabStop = true;
            rbNormalClass.Text = "Normal Class";
            rbNormalClass.UseVisualStyleBackColor = true;
            // 
            // rbBusinessClass
            // 
            rbBusinessClass.AutoSize = true;
            rbBusinessClass.Location = new Point(513, 423);
            rbBusinessClass.Name = "rbBusinessClass";
            rbBusinessClass.Size = new Size(190, 32);
            rbBusinessClass.TabIndex = 13;
            rbBusinessClass.TabStop = true;
            rbBusinessClass.Text = "Bussiness Class";
            rbBusinessClass.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 477);
            label8.Name = "label8";
            label8.Size = new Size(187, 28);
            label8.TabIndex = 14;
            label8.Text = "Aditional Options";
            // 
            // chkTravelInsurance
            // 
            chkTravelInsurance.AutoSize = true;
            chkTravelInsurance.Location = new Point(46, 522);
            chkTravelInsurance.Name = "chkTravelInsurance";
            chkTravelInsurance.Size = new Size(408, 32);
            chkTravelInsurance.TabIndex = 15;
            chkTravelInsurance.Text = "Add Travel Insurence ($25 per ticket)";
            chkTravelInsurance.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(789, -4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(465, 676);
            listBox1.TabIndex = 16;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(60, 595);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 17;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(230, 595);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(414, 595);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1599, 745);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(listBox1);
            Controls.Add(chkTravelInsurance);
            Controls.Add(label8);
            Controls.Add(rbBusinessClass);
            Controls.Add(rbNormalClass);
            Controls.Add(rbFirstClass);
            Controls.Add(label7);
            Controls.Add(txtBaggageWeight);
            Controls.Add(txtNumberOfTickets);
            Controls.Add(txtPassengerAge);
            Controls.Add(txtPassengerName);
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
            Load += Form1_Load;
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
        private TextBox txtPassengerName;
        private TextBox txtPassengerAge;
        private TextBox txtNumberOfTickets;
        private TextBox txtBaggageWeight;
        private Label label7;
        private RadioButton rbFirstClass;
        private RadioButton rbNormalClass;
        private RadioButton rbBusinessClass;
        private Label label8;
        private CheckBox chkTravelInsurance;
        private ListBox listBox1;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
