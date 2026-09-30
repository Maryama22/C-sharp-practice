using System;
using System.Windows.Forms;

namespace Tip_Tax_and_Total
{
    public partial class Form1 : Form
    {
        
        private const decimal RICE_PRICE = 5.00m;
        private const decimal PASTA_PRICE = 6.50m;
        private const decimal CHICKEN_PRICE = 8.00m;
        private const decimal FISH_PRICE = 9.25m;

        private const decimal TIP_RATE = 0.15m;   
        private const decimal TAX_RATE = 0.07m;   

        
        public Form1()
        {
            InitializeComponent();
        }

        private decimal GetPrice(string food)
        {
            string name = food.Trim().ToLower();

            if (name == "rice") return RICE_PRICE;
            else if (name == "pasta") return PASTA_PRICE;
            else if (name == "chicken") return CHICKEN_PRICE;
            else if (name == "fish") return FISH_PRICE;
            else throw new Exception("Cuntadan ma jirto: " + food);
        }

       
        private void sgowButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal price1 = GetPrice(Food1TextBox.Text);   
                decimal price2 = GetPrice(food2TextBox.Text);  

                price1TextBox.Text = price1.ToString("c");     
                price2textBox.Text = price2.ToString("c");      

                decimal foodCharge = price1 + price2;
                decimal tip = foodCharge * TIP_RATE;
                decimal tax = foodCharge * TAX_RATE;
                decimal total = foodCharge + tip + tax;

                resultLabel.Text =
                    "Food Charge: " + foodCharge.ToString("c") + "\n" +
                    "Tip (15%): " + tip.ToString("c") + "\n" +
                    "Tax (7%): " + tax.ToString("c") + "\n" +
                    "Total: " + total.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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