namespace Assigment_Files
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
            btnReader = new Button();
            btnDelete = new Button();
            btnDeleteItems = new Button();
            OutputList = new ListBox();
            SuspendLayout();
            // 
            // btnReader
            // 
            btnReader.BackColor = SystemColors.ActiveCaption;
            btnReader.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReader.Location = new Point(12, 65);
            btnReader.Name = "btnReader";
            btnReader.Size = new Size(261, 119);
            btnReader.TabIndex = 0;
            btnReader.Text = "Reading Other Function";
            btnReader.UseVisualStyleBackColor = false;
            btnReader.Click += btnReader_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.GradientInactiveCaption;
            btnDelete.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(269, 228);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(261, 119);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Deleting the File";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDeleteItems
            // 
            btnDeleteItems.BackColor = Color.SaddleBrown;
            btnDeleteItems.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteItems.ForeColor = Color.Transparent;
            btnDeleteItems.Location = new Point(514, 408);
            btnDeleteItems.Name = "btnDeleteItems";
            btnDeleteItems.Size = new Size(261, 119);
            btnDeleteItems.TabIndex = 2;
            btnDeleteItems.Text = "Delete The Items File";
            btnDeleteItems.UseVisualStyleBackColor = false;
            btnDeleteItems.Click += btnDeleteItems_Click;
            // 
            // OutputList
            // 
            OutputList.BackColor = Color.PeachPuff;
            OutputList.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OutputList.FormattingEnabled = true;
            OutputList.ItemHeight = 28;
            OutputList.Items.AddRange(new object[] { "Displaying the file Function" });
            OutputList.Location = new Point(875, 23);
            OutputList.Name = "OutputList";
            OutputList.Size = new Size(359, 536);
            OutputList.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1265, 659);
            Controls.Add(OutputList);
            Controls.Add(btnDeleteItems);
            Controls.Add(btnDelete);
            Controls.Add(btnReader);
            Name = "Form1";
            Text = "Assigment Files";
            Load += Form1_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private Button btnReader;
        private Button btnDelete;
        private Button btnDeleteItems;
        private ListBox OutputList;
    }
}
