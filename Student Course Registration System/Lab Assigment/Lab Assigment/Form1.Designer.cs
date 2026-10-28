namespace Lab_Assigment
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            schoolershipCheck = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            StudentId = new TextBox();
            StudentAge = new TextBox();
            StudentNameTxt = new TextBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            removeButton = new Button();
            AddButton = new Button();
            label6 = new Label();
            label5 = new Label();
            priceCourseTxt = new TextBox();
            NameCourseTxt = new TextBox();
            Registerlist = new ListBox();
            resultlist = new ListBox();
            btnCalculate = new Button();
            clearButton = new Button();
            exitButton = new Button();
            CourseNum = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.CornflowerBlue;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(715, 64);
            label1.TabIndex = 1;
            label1.Text = "Student Course Registration Course";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(schoolershipCheck);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(StudentId);
            groupBox1.Controls.Add(StudentAge);
            groupBox1.Controls.Add(StudentNameTxt);
            groupBox1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(564, 212);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Information";
            // 
            // schoolershipCheck
            // 
            schoolershipCheck.AutoSize = true;
            schoolershipCheck.Location = new Point(23, 161);
            schoolershipCheck.Name = "schoolershipCheck";
            schoolershipCheck.Size = new Size(405, 32);
            schoolershipCheck.TabIndex = 6;
            schoolershipCheck.Text = "Schoolership Student (20% Discount)";
            schoolershipCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 120);
            label4.Name = "label4";
            label4.Size = new Size(117, 28);
            label4.TabIndex = 5;
            label4.Text = "Student ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 75);
            label3.Name = "label3";
            label3.Size = new Size(134, 28);
            label3.TabIndex = 4;
            label3.Text = "Student Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 34);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 3;
            label2.Text = "Student Name";
            // 
            // StudentId
            // 
            StudentId.Location = new Point(209, 120);
            StudentId.Name = "StudentId";
            StudentId.Size = new Size(321, 35);
            StudentId.TabIndex = 2;
            // 
            // StudentAge
            // 
            StudentAge.Location = new Point(209, 72);
            StudentAge.Name = "StudentAge";
            StudentAge.Size = new Size(321, 35);
            StudentAge.TabIndex = 1;
            // 
            // StudentNameTxt
            // 
            StudentNameTxt.Location = new Point(209, 31);
            StudentNameTxt.Name = "StudentNameTxt";
            StudentNameTxt.Size = new Size(321, 35);
            StudentNameTxt.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightGreen;
            groupBox2.Controls.Add(CourseNum);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(removeButton);
            groupBox2.Controls.Add(AddButton);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(priceCourseTxt);
            groupBox2.Controls.Add(NameCourseTxt);
            groupBox2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 305);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(574, 221);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Course Information";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 132);
            label7.Name = "label7";
            label7.Size = new Size(208, 28);
            label7.TabIndex = 7;
            label7.Text = "Number Of Courses";
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.Red;
            removeButton.ForeColor = Color.White;
            removeButton.Location = new Point(237, 172);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(191, 43);
            removeButton.TabIndex = 5;
            removeButton.Text = "Remove Course";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.DarkGreen;
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(35, 172);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(154, 43);
            AddButton.TabIndex = 4;
            AddButton.Text = "Add Course";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 89);
            label6.Name = "label6";
            label6.Size = new Size(170, 28);
            label6.TabIndex = 3;
            label6.Text = "Course Price($):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 37);
            label5.Name = "label5";
            label5.Size = new Size(144, 28);
            label5.TabIndex = 2;
            label5.Text = "Course Name";
            // 
            // priceCourseTxt
            // 
            priceCourseTxt.Location = new Point(247, 89);
            priceCourseTxt.Name = "priceCourseTxt";
            priceCourseTxt.Size = new Size(299, 35);
            priceCourseTxt.TabIndex = 1;
            // 
            // NameCourseTxt
            // 
            NameCourseTxt.Location = new Point(247, 37);
            NameCourseTxt.Name = "NameCourseTxt";
            NameCourseTxt.Size = new Size(299, 35);
            NameCourseTxt.TabIndex = 0;
            // 
            // Registerlist
            // 
            Registerlist.BackColor = Color.PeachPuff;
            Registerlist.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registerlist.FormattingEnabled = true;
            Registerlist.ItemHeight = 28;
            Registerlist.Location = new Point(12, 532);
            Registerlist.Name = "Registerlist";
            Registerlist.Size = new Size(476, 172);
            Registerlist.TabIndex = 3;
            // 
            // resultlist
            // 
            resultlist.BackColor = Color.FromArgb(255, 192, 255);
            resultlist.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultlist.FormattingEnabled = true;
            resultlist.ItemHeight = 28;
            resultlist.Location = new Point(772, 0);
            resultlist.Name = "resultlist";
            resultlist.Size = new Size(484, 592);
            resultlist.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.SkyBlue;
            btnCalculate.Location = new Point(624, 599);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(149, 79);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.FromArgb(255, 128, 0);
            clearButton.Location = new Point(791, 593);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 78);
            clearButton.TabIndex = 6;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = SystemColors.AppWorkspace;
            exitButton.Location = new Point(961, 593);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(160, 78);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // CourseNum
            // 
            CourseNum.Location = new Point(247, 132);
            CourseNum.Name = "CourseNum";
            CourseNum.Size = new Size(299, 35);
            CourseNum.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 697);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(btnCalculate);
            Controls.Add(resultlist);
            Controls.Add(Registerlist);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox StudentId;
        private TextBox StudentAge;
        private TextBox StudentNameTxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox schoolershipCheck;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private TextBox priceCourseTxt;
        private TextBox NameCourseTxt;
        private Button removeButton;
        private Button AddButton;
        private ListBox Registerlist;
        private ListBox resultlist;
        private Button btnCalculate;
        private Button clearButton;
        private Button exitButton;
        private Label label7;
        private TextBox CourseNum;
    }
}