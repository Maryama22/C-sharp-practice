namespace Hospital_patient_system
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
            groupBox1 = new GroupBox();
            femaleRadio = new RadioButton();
            maleRadio = new RadioButton();
            patientAgetx = new TextBox();
            patientNametx = new TextBox();
            patientIdtx = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            patientListBox = new ListBox();
            registerbutton = new Button();
            viewbutton = new Button();
            removebutton = new Button();
            countbutton = new Button();
            btnClear = new Button();
            btnExit = new Button();
            totalTx = new TextBox();
            label6 = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(38, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1645, 76);
            label1.TabIndex = 0;
            label1.Text = "Hospital Patient Registration System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(femaleRadio);
            groupBox1.Controls.Add(maleRadio);
            groupBox1.Controls.Add(patientAgetx);
            groupBox1.Controls.Add(patientNametx);
            groupBox1.Controls.Add(patientIdtx);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(17, 108);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(827, 386);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient Information";
            // 
            // femaleRadio
            // 
            femaleRadio.AutoSize = true;
            femaleRadio.Location = new Point(448, 316);
            femaleRadio.Margin = new Padding(4);
            femaleRadio.Name = "femaleRadio";
            femaleRadio.Size = new Size(121, 36);
            femaleRadio.TabIndex = 8;
            femaleRadio.TabStop = true;
            femaleRadio.Text = "Female";
            femaleRadio.UseVisualStyleBackColor = true;
            femaleRadio.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // maleRadio
            // 
            maleRadio.AutoSize = true;
            maleRadio.Location = new Point(130, 316);
            maleRadio.Margin = new Padding(4);
            maleRadio.Name = "maleRadio";
            maleRadio.Size = new Size(96, 36);
            maleRadio.TabIndex = 7;
            maleRadio.TabStop = true;
            maleRadio.Text = "Male";
            maleRadio.UseVisualStyleBackColor = true;
            // 
            // patientAgetx
            // 
            patientAgetx.Location = new Point(321, 196);
            patientAgetx.Margin = new Padding(4);
            patientAgetx.Name = "patientAgetx";
            patientAgetx.Size = new Size(467, 40);
            patientAgetx.TabIndex = 6;
            // 
            // patientNametx
            // 
            patientNametx.Location = new Point(321, 121);
            patientNametx.Margin = new Padding(4);
            patientNametx.Name = "patientNametx";
            patientNametx.Size = new Size(467, 40);
            patientNametx.TabIndex = 5;
            // 
            // patientIdtx
            // 
            patientIdtx.Location = new Point(321, 43);
            patientIdtx.Margin = new Padding(4);
            patientIdtx.Name = "patientIdtx";
            patientIdtx.Size = new Size(467, 40);
            patientIdtx.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 260);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 32);
            label5.TabIndex = 3;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 180);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 32);
            label4.TabIndex = 2;
            label4.Text = "Age:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 110);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(181, 32);
            label3.TabIndex = 1;
            label3.Text = "Patient Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 43);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 32);
            label2.TabIndex = 0;
            label2.Text = "Patient ID:";
            // 
            // patientListBox
            // 
            patientListBox.BackColor = SystemColors.Info;
            patientListBox.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientListBox.FormattingEnabled = true;
            patientListBox.ItemHeight = 30;
            patientListBox.Items.AddRange(new object[] { "Patient Record" });
            patientListBox.Location = new Point(1211, 91);
            patientListBox.Margin = new Padding(4);
            patientListBox.Name = "patientListBox";
            patientListBox.Size = new Size(487, 514);
            patientListBox.TabIndex = 2;
            // 
            // registerbutton
            // 
            registerbutton.BackColor = Color.PaleGreen;
            registerbutton.Location = new Point(38, 656);
            registerbutton.Margin = new Padding(4);
            registerbutton.Name = "registerbutton";
            registerbutton.Size = new Size(221, 78);
            registerbutton.TabIndex = 3;
            registerbutton.Text = "Record patient";
            registerbutton.UseVisualStyleBackColor = false;
            registerbutton.Click += registerbutton_Click;
            // 
            // viewbutton
            // 
            viewbutton.BackColor = SystemColors.ActiveCaption;
            viewbutton.Location = new Point(300, 659);
            viewbutton.Margin = new Padding(4);
            viewbutton.Name = "viewbutton";
            viewbutton.Size = new Size(179, 78);
            viewbutton.TabIndex = 4;
            viewbutton.Text = "View From File";
            viewbutton.UseVisualStyleBackColor = false;
            viewbutton.Click += viewbutton_Click;
            // 
            // removebutton
            // 
            removebutton.BackColor = Color.Red;
            removebutton.Location = new Point(545, 658);
            removebutton.Margin = new Padding(4);
            removebutton.Name = "removebutton";
            removebutton.Size = new Size(179, 78);
            removebutton.TabIndex = 5;
            removebutton.Text = "Remove Selected";
            removebutton.UseVisualStyleBackColor = false;
            removebutton.Click += removebutton_Click;
            // 
            // countbutton
            // 
            countbutton.BackColor = Color.Orchid;
            countbutton.Location = new Point(787, 656);
            countbutton.Margin = new Padding(4);
            countbutton.Name = "countbutton";
            countbutton.Size = new Size(172, 78);
            countbutton.TabIndex = 6;
            countbutton.Text = "Count Patient";
            countbutton.UseVisualStyleBackColor = false;
            countbutton.Click += countbutton_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlDark;
            btnClear.Location = new Point(990, 656);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(164, 78);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Firebrick;
            btnExit.Location = new Point(1184, 656);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(189, 80);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // totalTx
            // 
            totalTx.Location = new Point(1395, 602);
            totalTx.Name = "totalTx";
            totalTx.Size = new Size(198, 37);
            totalTx.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1237, 609);
            label6.Name = "label6";
            label6.Size = new Size(152, 30);
            label6.TabIndex = 10;
            label6.Text = "Total Patient";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1780, 739);
            Controls.Add(label6);
            Controls.Add(totalTx);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(countbutton);
            Controls.Add(removebutton);
            Controls.Add(viewbutton);
            Controls.Add(registerbutton);
            Controls.Add(patientListBox);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton maleRadio;
        private TextBox patientAgetx;
        private TextBox patientNametx;
        private TextBox patientIdtx;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton femaleRadio;
        private ListBox patientListBox;
        private Button registerbutton;
        private Button viewbutton;
        private Button removebutton;
        private Button countbutton;
        private Button btnClear;
        private Button btnExit;
        private TextBox totalTx;
        private Label label6;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
