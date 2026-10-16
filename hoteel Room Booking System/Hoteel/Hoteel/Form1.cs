namespace Hoteel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1. Validate numeric inputs using TryParse
            if (!int.TryParse(txtGuestAge.Text, out int guestAge))
            {
                MessageBox.Show("Fadlan geli da' sax ah (Number).", "Khalad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtNumberOfNights.Text, out int nights))
            {
                MessageBox.Show("Fadlan geli tirada habeenada oo sax ah (Number).", "Khalad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtNumberOfGuests.Text, out int guests))
            {
                MessageBox.Show("Fadlan geli tirada martida oo sax ah (Number).", "Khalad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Validate ranges and rules
            // - Guest age must be between 18 and 90
            if (guestAge < 18 || guestAge > 90)
            {
                MessageBox.Show("Da'da martida waa inay u dhaxaysaa 18 iyo 90.", "Xeerka Da'da", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // - Number of nights must be between 1 and 30
            if (nights < 1 || nights > 30)
            {
                MessageBox.Show("Tirada habeenadu waa inay u dhaxaysaa 1 iyo 30.", "Xeerka Habeenada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // - Number of guests must be between 1 and 6
            if (guests < 1 || guests > 6)
            {
                MessageBox.Show("Tirada martidu waa inay u dhaxaysaa 1 iyo 6.", "Xeerka Martida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // - High can accommodate a maximum of 6 guests
            // - Standard rooms can accommodate a maximum of 2 guests
            // - Normal rooms can accommodate a maximum of 4 guests
            string roomType = "";
            double ratePerNight = 0;

            if (rbStandard.Checked)
            {
                roomType = "Standard";
                if (guests > 2)
                {
                    MessageBox.Show("Qolka Standard wuxuu qaadaa ugu badnaan 2 marti ah.", "Xeerka Qolka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (rbNormal.Checked)
            {
                roomType = "Normal";
                if (guests > 4)
                {
                    MessageBox.Show("Qolka Normal wuxuu qaadaa ugu badnaan 4 marti ah.", "Xeerka Qolka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (rbHigh.Checked)
            {
                roomType = "High";
                if (guests > 6)
                {
                    MessageBox.Show("Qolka High wuxuu qaadaa ugu badnaan 6 marti ah.", "Xeerka Qolka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Fadlan dooro nooca qolka (Room Type).", "Khalad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Use a switch statement to determine the room rate
            switch (roomType)
            {
                case "Standard":
                    ratePerNight = 50;
                    break;
                case "Normal":
                    ratePerNight = 80;
                    break;
                case "High":
                    ratePerNight = 130;
                    break;
            }

            // Calculations
            double basicRoomCost = ratePerNight * nights;
            double stayDiscount = 0;

            // Cost Rules - Stay duration discounts:
            // - 1-4 nights: No discount
            // - 5-9 nights: 5% discount
            // - 10 or more nights: 12% discount
            if (nights >= 10)
            {
                stayDiscount = basicRoomCost * 0.12;
            }
            else if (nights >= 5)
            {
                stayDiscount = basicRoomCost * 0.05;
            }

            // Breakfast selected: add $10 per guest per night
            double breakfastCost = 0;
            if (chkBreakfast.Checked)
            {
                breakfastCost = 10 * guests * nights;
            }

            // More than 4 guests: add a 5% service surcharge
            double serviceSurcharge = 0;
            if (guests > 4)
            {
                serviceSurcharge = basicRoomCost * 0.05;
            }

            // Guests aged 60 or above receive an additional 5% senior discount
            double seniorDiscount = 0;
            if (guestAge >= 60)
            {
                seniorDiscount = basicRoomCost * 0.05;
            }

            // Determine whether the booking is approved or rejected
            string bookingStatus = "APPROVED";

            // Total Final Cost calculation
            double finalCost = basicRoomCost - stayDiscount - seniorDiscount + breakfastCost + serviceSurcharge;

            // Display results in the ListBox (magaca listbox-ka waa listBox1)
            listBox1.Items.Clear();
            listBox1.Items.Add($"Guest Name: {txtGuestName.Text}");
            listBox1.Items.Add($"Guest Age: {guestAge}");
            listBox1.Items.Add($"Number of Guests: {guests}");
            listBox1.Items.Add($"Number of Nights: {nights}");
            listBox1.Items.Add($"Room Type: {roomType}");
            listBox1.Items.Add($"Rate Per Night: ${ratePerNight:F2}");
            listBox1.Items.Add($"Basic Room Cost: ${basicRoomCost:F2}");
            listBox1.Items.Add($"Stay Discount: ${stayDiscount:F2}");
            listBox1.Items.Add($"Senior Discount: ${seniorDiscount:F2}");
            listBox1.Items.Add($"Breakfast Cost: ${breakfastCost:F2}");
            listBox1.Items.Add($"Service Surcharge: ${serviceSurcharge:F2}");
            listBox1.Items.Add("");
            listBox1.Items.Add($"Final Cost: ${finalCost:F2}");
            listBox1.Items.Add($"Booking Status: {bookingStatus}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuestName.Clear();
            txtGuestAge.Clear();
            txtNumberOfNights.Clear();
            txtNumberOfGuests.Clear();
            rbStandard.Checked = false;
            rbNormal.Checked = false;
            rbHigh.Checked = false;
            chkBreakfast.Checked = false;
            listBox1.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

