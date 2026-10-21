namespace Assigment_One
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
            label5 = new Label();
            txtname = new TextBox();
            txtdepartment = new TextBox();
            txtsemester = new TextBox();
            txtstudentid = new TextBox();
            lblname = new Label();
            lblstudentid = new Label();
            lbldepartment = new Label();
            lblsemester = new Label();
            lbloutput = new Label();
            btnshowinfo = new Button();
            btnclear = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(150, 9);
            label5.Name = "label5";
            label5.Size = new Size(366, 38);
            label5.TabIndex = 4;
            label5.Text = "STUDENT INFORMATION";
            // 
            // txtname
            // 
            txtname.BorderStyle = BorderStyle.FixedSingle;
            txtname.Location = new Point(464, 98);
            txtname.Name = "txtname";
            txtname.Size = new Size(290, 31);
            txtname.TabIndex = 5;
            // 
            // txtdepartment
            // 
            txtdepartment.BorderStyle = BorderStyle.FixedSingle;
            txtdepartment.Location = new Point(464, 229);
            txtdepartment.Name = "txtdepartment";
            txtdepartment.Size = new Size(290, 31);
            txtdepartment.TabIndex = 6;
            txtdepartment.TextChanged += textBox2_TextChanged;
            // 
            // txtsemester
            // 
            txtsemester.BorderStyle = BorderStyle.FixedSingle;
            txtsemester.Location = new Point(464, 304);
            txtsemester.Name = "txtsemester";
            txtsemester.Size = new Size(290, 31);
            txtsemester.TabIndex = 7;
            // 
            // txtstudentid
            // 
            txtstudentid.BorderStyle = BorderStyle.FixedSingle;
            txtstudentid.Location = new Point(464, 162);
            txtstudentid.Name = "txtstudentid";
            txtstudentid.Size = new Size(290, 31);
            txtstudentid.TabIndex = 8;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblname.Location = new Point(171, 99);
            lblname.Name = "lblname";
            lblname.Size = new Size(258, 30);
            lblname.TabIndex = 9;
            lblname.Text = "Enter the Student name";
            lblname.Click += lblname_Click;
            // 
            // lblstudentid
            // 
            lblstudentid.AutoSize = true;
            lblstudentid.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblstudentid.Location = new Point(171, 163);
            lblstudentid.Name = "lblstudentid";
            lblstudentid.Size = new Size(224, 30);
            lblstudentid.TabIndex = 10;
            lblstudentid.Text = "Enter the Student ID";
            // 
            // lbldepartment
            // 
            lbldepartment.AutoSize = true;
            lbldepartment.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldepartment.Location = new Point(171, 230);
            lbldepartment.Name = "lbldepartment";
            lbldepartment.Size = new Size(239, 30);
            lbldepartment.TabIndex = 11;
            lbldepartment.Text = "Enter the department";
            lbldepartment.Click += lbldepartment_Click;
            // 
            // lblsemester
            // 
            lblsemester.AutoSize = true;
            lblsemester.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsemester.Location = new Point(188, 305);
            lblsemester.Name = "lblsemester";
            lblsemester.Size = new Size(208, 30);
            lblsemester.TabIndex = 12;
            lblsemester.Text = "Enter the semester";
            // 
            // lbloutput
            // 
            lbloutput.BorderStyle = BorderStyle.FixedSingle;
            lbloutput.Location = new Point(171, 439);
            lbloutput.Name = "lbloutput";
            lbloutput.Size = new Size(618, 80);
            lbloutput.TabIndex = 13;
            // 
            // btnshowinfo
            // 
            btnshowinfo.AllowDrop = true;
            btnshowinfo.AutoSize = true;
            btnshowinfo.BackColor = SystemColors.ButtonHighlight;
            btnshowinfo.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnshowinfo.ForeColor = Color.Black;
            btnshowinfo.Location = new Point(188, 536);
            btnshowinfo.Name = "btnshowinfo";
            btnshowinfo.Size = new Size(201, 38);
            btnshowinfo.TabIndex = 14;
            btnshowinfo.Text = "Show information";
            btnshowinfo.UseVisualStyleBackColor = false;
            btnshowinfo.Click += btnshowinfo_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = SystemColors.ButtonHighlight;
            btnclear.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(440, 532);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(135, 42);
            btnclear.TabIndex = 15;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = SystemColors.ButtonHighlight;
            btnexit.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnexit.Location = new Point(606, 536);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(136, 38);
            btnexit.TabIndex = 16;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 652);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(btnshowinfo);
            Controls.Add(lbloutput);
            Controls.Add(lblsemester);
            Controls.Add(lbldepartment);
            Controls.Add(lblstudentid);
            Controls.Add(lblname);
            Controls.Add(txtstudentid);
            Controls.Add(txtsemester);
            Controls.Add(txtdepartment);
            Controls.Add(txtname);
            Controls.Add(label5);
            Name = "Form1";
            Text = "Student Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox txtname;
        private TextBox txtdepartment;
        private TextBox txtsemester;
        private TextBox txtstudentid;
        private Label lblname;
        private Label lblstudentid;
        private Label lbldepartment;
        private Label lblsemester;
        private Label lbloutput;
        private Button btnshowinfo;
        private Button btnclear;
        private Button btnexit;
    }
}
