using System;
using System.Windows.Forms;

namespace Tip_Tax_and_Total
{
    public partial class Form1 : Form
    {
        // ===== CONSTANTS =====
        private const double TIP_RATE = 0.15;   
        private const double TAX_RATE = 0.07;   

        public Form1()
        {
            InitializeComponent();
        }

        private void sgowButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name1 = Food1TextBox.Text;
                string name2 = food2TextBox.Text;

                double price1 = double.Parse(price1TextBox.Text);
                double price2 = double.Parse(price2textBox.Text);

                double foodCharge = price1 + price2;
                double tip = foodCharge * TIP_RATE;
                double tax = foodCharge * TAX_RATE;
                double total = foodCharge + tip + tax;

                resultLabel.Text =
                    name1 + " : " + price1.ToString("c") + "\n" +
                    name2 + " : " + price2.ToString("c") + "\n" +
                    "Food Charge: " + foodCharge.ToString("c") + "\n" +
                    "Tip (15%): " + tip.ToString("c") + "\n" +
                    "Tax (7%): " + tax.ToString("c") + "\n" +
                    "Total: " + total.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fadlan geli qiime sax ah. " + ex.Message);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Food1TextBox.Clear();
            price1TextBox.Clear();
            food2TextBox.Clear();
            price2textBox.Clear();
            resultLabel.Text = "";
            Food1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}