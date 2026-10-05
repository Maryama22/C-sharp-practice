namespace Range_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Convert input text to integer
                int number = int.Parse(txtInput.Text);

                // 2. Range checking using Logical Operator (&&)
                if (number >= 1 && number <= 10)
                {
                    lblDecision.Text = "The number is valid and within range (1 - 10).";
                }
                else
                {
                    lblDecision.Text = "The number is outside the range (1 - 10).";
                }
            }
            catch (FormatException)
            {
                // Handle non-integer or text inputs
                MessageBox.Show("Please enter a valid integer number.");
                lblDecision.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lblDecision.Text = "";
            txtInput.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

