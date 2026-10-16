namespace Airline_Ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPassengerAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBaggageWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbFirstClass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string passengerName = txtPassengerName.Text;

            if (string.IsNullOrEmpty(passengerName))
            {
                MessageBox.Show("gali magaca rakaabka");
                return;
            }

            foreach (char c in passengerName)
            {
                if (char.IsDigit(c))
                {
                    MessageBox.Show("magaca rakaabka waa in uu ku koobnadaa xarfo oo kaliya");
                    return;
                }
            }

            if (!int.TryParse(txtPassengerAge.Text, out int passengerAge))
            {
                MessageBox.Show("fadlan gali da'da saxda ah");
                return;
            }

            if (!int.TryParse(txtNumberOfTickets.Text, out int tickets))
            {
                MessageBox.Show("fadlan gali tirada ticket");
                return;
            }

            if (!double.TryParse(txtBaggageWeight.Text, out double baggageWeight))
            {
                MessageBox.Show("fadlan gali qiimaha boorsada");
                return;
            }

            if (passengerAge < 1 || passengerAge > 100)
            {
                MessageBox.Show("da'da rakaabka waa in ay u dhaxeesaa 1 ilaa 100");
                return;
            }

            if (tickets < 1 || tickets > 5)
            {
                MessageBox.Show("Tirada ticket waa in uu dhaxeeyaa 1-5");
                return;
            }

            if (baggageWeight < 0 || baggageWeight > (80 * tickets))
            {
                MessageBox.Show("80kg ka badan lama ogala.");
                return;
            }

            string flightClass = "";
            double ticketPrice = 0;

            if (rbFirstClass.Checked)
            {
                flightClass = "First Class";
                ticketPrice = 150; //  qiimaha First Class
            }
            else if (rbNormalClass.Checked)
            {
                flightClass = "Normal Class";
                ticketPrice = 300; // qiimaha Normal Class
            }
            else if (rbBusinessClass.Checked)
            {

                flightClass = "Business Class";
                ticketPrice = 500; // qiimaha Business Class
            }
            else
            {
                MessageBox.Show("fadlan dooro nooca Fasalka ");
                return;
            }

            if (passengerAge < 12 && flightClass == "First Class")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add($"Passenger Name: {passengerName}");
                listBox1.Items.Add($"Passenger Age: {passengerAge}");
                listBox1.Items.Add($"Flight Class: {flightClass}");
                listBox1.Items.Add($"Number of Tickets: {tickets}");
                listBox1.Items.Add($"Baggage Weight: {baggageWeight} kg");
                listBox1.Items.Add("");
                listBox1.Items.Add("Booking Status: REJECTED");
                listBox1.Items.Add("Reason: Passengers under 12 cannot book First Class.");
                return;
            }

            double basicTicketCost = ticketPrice * tickets;
            double discount = 0;


            if (tickets == 5)
            {
                discount = basicTicketCost * 0.10;
            }
            else if (tickets >= 3 && tickets <= 4)
            {
                discount = basicTicketCost * 0.05;
            }

            if (passengerAge < 12)
            {
                discount += basicTicketCost * 0.20;
            }
            else if (passengerAge >= 60)
            {
                discount += basicTicketCost * 0.10;
            }

            double insuranceCost = 0;
            if (chkTravelInsurance.Checked)
            {
                insuranceCost = 25 * tickets;
            }

            string bookingStatus = "APPROVED";
            double finalCost = basicTicketCost - discount + insuranceCost;

            listBox1.Items.Clear();
            listBox1.Items.Add($"Passenger Name: {passengerName}");
            listBox1.Items.Add($"Passenger Age: {passengerAge}");
            listBox1.Items.Add($"Flight Class: {flightClass}");
            listBox1.Items.Add($"Number of Tickets: {tickets}");
            listBox1.Items.Add($"Baggage Weight: {baggageWeight} kg");
            listBox1.Items.Add($"Basic Ticket Cost: ${basicTicketCost:F2}");
            listBox1.Items.Add($"Total Discount: ${discount:F2}");
            listBox1.Items.Add($"Insurance Cost: ${insuranceCost:F2}");
            listBox1.Items.Add("");
            listBox1.Items.Add($"Final Cost: ${finalCost:F2}");
            listBox1.Items.Add($"Booking Status: {bookingStatus}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassengerName.Clear();
            txtPassengerAge.Clear();
            txtNumberOfTickets.Clear();
            txtBaggageWeight.Clear();
            rbFirstClass.Checked = false;
            rbNormalClass.Checked = false;
            rbBusinessClass.Checked = false;
            chkTravelInsurance.Checked = false;
            listBox1.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

