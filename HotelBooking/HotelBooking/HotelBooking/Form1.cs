namespace HotelBooking
{
    public partial class Form1 : Form
    {
        // ===== CONSTANTS =====
        private const decimal SERVICE_TAX_RATE = 0.10m;   // 10%
        private const decimal DISCOUNT_RATE = 0.05m;   // 5%

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Gelinta
                string guestName = txtGuestName.Text.Trim();
                string roomType = txtRoomType.Text.Trim();

                // * Check-iga: Hubi in magaca ama roomType ay ku jiraan tirooyin *
                if (guestName.Any(char.IsDigit) || roomType.Any(char.IsDigit))
                {
                    MessageBox.Show("Fadlan magaca ama room type-ka ha u isticmaalin nambaro!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Ka jooji xisaabinta
                }

                // Hubi inaysan meelna maran ahayn
                if (string.IsNullOrEmpty(guestName) || string.IsNullOrEmpty(roomType))
                {
                    MessageBox.Show("Fadlan soo gali magaca iyo room type-ka!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int nights = int.Parse(txtNights.Text);
                decimal price = decimal.Parse(txtPriceNight.Text);

                // 2) Xisaab
                decimal subtotal = nights * price;
                decimal tax = subtotal * SERVICE_TAX_RATE;
                decimal discount = subtotal * DISCOUNT_RATE;
                decimal total = subtotal + tax - discount;

                // 3) Muujin
                lblServiceTax.Text = tax.ToString("c");
                lblDiscount.Text = discount.ToString("c");
                lblTotalAmount.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fadlan geli xog sax ah. " + ex.Message);
            }
        }
    }
    }

