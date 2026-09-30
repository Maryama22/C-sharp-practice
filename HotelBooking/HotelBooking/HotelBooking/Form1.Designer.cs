namespace HotelBooking
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
            txtGuestName = new TextBox();
            txtRoomType = new TextBox();
            txtNights = new TextBox();
            txtPriceNight = new TextBox();
            btnCalculate = new Button();
            lblTotalAmount = new Label();
            lblDiscount = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            lblServiceTax = new Label();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(688, 73);
            label1.TabIndex = 0;
            label1.Text = "Hotel Room Booking Calculator";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label2.Location = new Point(517, 198);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(190, 28);
            label2.TabIndex = 1;
            label2.Text = "Enter Guest Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label3.Location = new Point(517, 260);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(183, 28);
            label3.TabIndex = 2;
            label3.Text = "Enter Room Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label4.Location = new Point(517, 337);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(250, 28);
            label4.TabIndex = 3;
            label4.Text = "Enter Number of Nights";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label5.Location = new Point(517, 401);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(219, 28);
            label5.TabIndex = 4;
            label5.Text = "Enter Price Per Night";
            // 
            // txtGuestName
            // 
            txtGuestName.Location = new Point(857, 198);
            txtGuestName.Margin = new Padding(4, 3, 4, 3);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.Size = new Size(322, 35);
            txtGuestName.TabIndex = 5;
            // 
            // txtRoomType
            // 
            txtRoomType.Location = new Point(857, 260);
            txtRoomType.Margin = new Padding(4, 3, 4, 3);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.Size = new Size(322, 35);
            txtRoomType.TabIndex = 6;
            // 
            // txtNights
            // 
            txtNights.Location = new Point(857, 334);
            txtNights.Margin = new Padding(4, 3, 4, 3);
            txtNights.Name = "txtNights";
            txtNights.Size = new Size(322, 35);
            txtNights.TabIndex = 7;
            // 
            // txtPriceNight
            // 
            txtPriceNight.Location = new Point(857, 401);
            txtPriceNight.Margin = new Padding(4, 3, 4, 3);
            txtPriceNight.Name = "txtPriceNight";
            txtPriceNight.Size = new Size(322, 35);
            txtPriceNight.TabIndex = 8;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.ActiveCaption;
            btnCalculate.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(611, 496);
            btnCalculate.Margin = new Padding(4, 3, 4, 3);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(326, 76);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Calculate Booking";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.BackColor = SystemColors.ControlLight;
            lblTotalAmount.BorderStyle = BorderStyle.FixedSingle;
            lblTotalAmount.Location = new Point(443, 130);
            lblTotalAmount.Margin = new Padding(4, 0, 4, 0);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(249, 35);
            lblTotalAmount.TabIndex = 10;
            lblTotalAmount.Click += lblTotalAmount_Click;
            // 
            // lblDiscount
            // 
            lblDiscount.BackColor = SystemColors.ControlLight;
            lblDiscount.BorderStyle = BorderStyle.FixedSingle;
            lblDiscount.Location = new Point(443, 68);
            lblDiscount.Margin = new Padding(4, 0, 4, 0);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(249, 35);
            lblDiscount.TabIndex = 12;
            lblDiscount.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(270, 24);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(123, 28);
            label9.TabIndex = 13;
            label9.Text = "service Tax";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(270, 75);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(146, 28);
            label10.TabIndex = 14;
            label10.Text = "Discount(5%)";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(266, 130);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(150, 28);
            label11.TabIndex = 15;
            label11.Text = "Total Amount";
            label11.Click += label11_Click;
            // 
            // lblServiceTax
            // 
            lblServiceTax.BackColor = SystemColors.ControlLight;
            lblServiceTax.BorderStyle = BorderStyle.FixedSingle;
            lblServiceTax.Location = new Point(443, 13);
            lblServiceTax.Name = "lblServiceTax";
            lblServiceTax.Size = new Size(249, 39);
            lblServiceTax.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(lblServiceTax);
            panel2.Controls.Add(lblDiscount);
            panel2.Controls.Add(lblTotalAmount);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(14, 620);
            panel2.Name = "panel2";
            panel2.Size = new Size(742, 167);
            panel2.TabIndex = 18;
            panel2.Paint += panel2_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1250, 799);
            Controls.Add(panel2);
            Controls.Add(btnCalculate);
            Controls.Add(txtPriceNight);
            Controls.Add(txtNights);
            Controls.Add(txtRoomType);
            Controls.Add(txtGuestName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtGuestName;
        private TextBox txtRoomType;
        private TextBox txtNights;
        private TextBox txtPriceNight;
        private Button btnCalculate;
        private Label lblTotalAmount;
        private Label lblDiscount;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label lblServiceTax;
        private Panel panel2;
    }
}
