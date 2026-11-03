namespace file_dialog_practice
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
            button1 = new Button();
            openFile = new OpenFileDialog();
            ListResult = new ListBox();
            saveFileDialog1 = new SaveFileDialog();
            button2 = new Button();
            txlShow = new TextBox();
            label1 = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(27, 12);
            button1.Name = "button1";
            button1.Size = new Size(383, 97);
            button1.TabIndex = 0;
            button1.Text = "open file dialog";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // openFile
            // 
            openFile.FileName = "openFileDialog1";
            openFile.FileOk += openFile_FileOk;
            // 
            // ListResult
            // 
            ListResult.BackColor = Color.PeachPuff;
            ListResult.FormattingEnabled = true;
            ListResult.ItemHeight = 25;
            ListResult.Location = new Point(755, 58);
            ListResult.Name = "ListResult";
            ListResult.Size = new Size(374, 479);
            ListResult.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(36, 157);
            button2.Name = "button2";
            button2.Size = new Size(374, 105);
            button2.TabIndex = 2;
            button2.Text = "Save file Dialog";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txlShow
            // 
            txlShow.Location = new Point(292, 315);
            txlShow.Name = "txlShow";
            txlShow.Size = new Size(334, 31);
            txlShow.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 318);
            label1.Name = "label1";
            label1.Size = new Size(250, 28);
            label1.TabIndex = 4;
            label1.Text = "Enter the taxt you want:";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(146, 423);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(239, 75);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 647);
            Controls.Add(btnClear);
            Controls.Add(label1);
            Controls.Add(txlShow);
            Controls.Add(button2);
            Controls.Add(ListResult);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private OpenFileDialog openFile;
        private ListBox ListResult;
        private SaveFileDialog saveFileDialog1;
        private Button button2;
        private TextBox txlShow;
        private Label label1;
        private Button btnClear;
    }
}
