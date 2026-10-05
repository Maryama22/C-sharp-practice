namespace pyroll_overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Double validation using double
            if (double.TryParse(hoursWorkedTextBox.Text, out double hoursWorked) &&
                double.TryParse(hourlyPayRateTextBox.Text, out double hourlyPayRate))
            {
                // Hubinta in nambaradu aysan ka yarayn 0 (Range validation)
                if (hoursWorked < 0 || hourlyPayRate < 0)
                {
                    MessageBox.Show("Hours and pay rate cannot be negative.");
                    return;
                }

                double grossPay = 0;
                const double BASE_HOURS = 40;
                const double OVERTIME_RATE = 1.5;

                // Overtime logic calculation
                if (hoursWorked > BASE_HOURS)
                {
                    double basePay = BASE_HOURS * hourlyPayRate;
                    double overtimeHours = hoursWorked - BASE_HOURS;
                    double overtimePay = overtimeHours * hourlyPayRate * OVERTIME_RATE;

                    grossPay = basePay + overtimePay;
                }
                else
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }

                // Display formatted result as currency ($)
                grossPayLabel.Text = grossPay.ToString("C");
            }
            else
            {
                // Show error message if input is not a double
                MessageBox.Show("Please enter valid numeric values for hours and pay rate.");
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear input fields and output label
            hoursWorkedTextBox.Clear();
            hourlyPayRateTextBox.Clear();
            grossPayLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
