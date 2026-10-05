namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Convert text inputs to double data types
                double score1 = double.Parse(txtScore1.Text);
                double score2 = double.Parse(txtScore2.Text);
                double score3 = double.Parse(txtScore3.Text);

                // 2. Validate input ranges using if-else-if (0 to 100)
                if (score1 < 0 || score1 > 100)
                {
                    MessageBox.Show("Test Score #1 must be between 0 and 100.");
                }
                else if (score2 < 0 || score2 > 100)
                {
                    MessageBox.Show("Test Score #2 must be between 0 and 100.");
                }
                else if (score3 < 0 || score3 > 100)
                {
                    MessageBox.Show("Test Score #3 must be between 0 and 100.");
                }
                else
                {
                    // 3. Calculate average and display output formatted to 1 decimal place
                    double average = (score1 + score2 + score3) / 3.0;
                    lblAverage.Text = average.ToString("0.0");
                }
            }
            catch (FormatException)
            {
                // Handle non-numeric input exceptions
                MessageBox.Show("Please enter valid numeric values for all test scores.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all text input fields
            txtScore1.Clear();
            txtScore2.Clear();
            txtScore3.Clear();

            // Clear the output result label
            lblAverage.Text = "";
        }
    }
}

