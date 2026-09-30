namespace Tip_Tax_and_Total
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
            Food1TextBox = new TextBox();
            price1TextBox = new TextBox();
            food2TextBox = new TextBox();
            price2textBox = new TextBox();
            sgowButton = new Button();
            exitButton = new Button();
            Clear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            resultLabel = new Label();
//            SuspendLayout();
            // 
            // Food1TextBox
            // 
            Food1TextBox.Location = new Point(609, 138);
            Food1TextBox.Name = "Food1TextBox";
            Food1TextBox.Size = new Size(260, 31);
            Food1TextBox.TabIndex = 0;
            // 
            // price1TextBox
            // 
            price1TextBox.Location = new Point(609, 175);
            price1TextBox.Name = "price1TextBox";
            price1TextBox.ReadOnly = true;
            price1TextBox.Size = new Size(260, 31);
            price1TextBox.TabIndex = 1;
            // 
            // food2TextBox
            // 
            food2TextBox.Location = new Point(609, 226);
            food2TextBox.Name = "food2TextBox";
            food2TextBox.ReadOnly = true;
            food2TextBox.Size = new Size(260, 31);
            food2TextBox.TabIndex = 2;
            // 
            // price2textBox
            // 
            price2textBox.Location = new Point(609, 276);
            price2textBox.Name = "price2textBox";
            price2textBox.Size = new Size(260, 31);
            price2textBox.TabIndex = 3;
            // 
            // sgowButton
            // 
            sgowButton.Location = new Point(192, 527);
            sgowButton.Name = "sgowButton";
            sgowButton.Size = new Size(132, 28);
            sgowButton.TabIndex = 4;
            sgowButton.Text = "show";
            sgowButton.UseVisualStyleBackColor = true;
            sgowButton.Click += sgowButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(641, 527);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            Clear.Location = new Point(419, 527);
            Clear.Name = "Clear";
            Clear.Size = new Size(112, 34);
            Clear.TabIndex = 6;
            Clear.Text = "clearButton";
            Clear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(428, 138);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 7;
            label1.Text = "food1:";
    //        label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(428, 181);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 8;
            label2.Text = "price1:";
    //        label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 232);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 9;
            label3.Text = "food2:";
   //         label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(419, 282);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(440, 292);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 11;
            label5.Text = "price2";
            // 
            // resultLabel
            // 
            resultLabel.BorderStyle = BorderStyle.FixedSingle;
            resultLabel.Location = new Point(192, 396);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(731, 111);
            resultLabel.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 705);
            Controls.Add(resultLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Clear);
            Controls.Add(exitButton);
            Controls.Add(sgowButton);
            Controls.Add(price2textBox);
            Controls.Add(food2TextBox);
            Controls.Add(price1TextBox);
            Controls.Add(Food1TextBox);
            Name = "Form1";
            Text = "Tip,Tax and Total";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Food1TextBox;
        private TextBox price1TextBox;
        private TextBox food2TextBox;
        private TextBox price2textBox;
        private Button sgowButton;
        private Button exitButton;
        private Button Clear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label resultLabel;
    }
}
