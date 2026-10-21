namespace Home_Assigment
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

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthlabel_Click(object sender, EventArgs e)
        {

        }

        private void yearpromt_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDateButton_Click(object sender, EventArgs e)

        {
            string dayOfWeek = dayOfWeekTextBox.Text;
            string month = monthTextBox.Text;
            string dayOfMonth = dayOfMonthTextBox.Text;
            string year = yearTextBox.Text;

            dateOutputLabel.Text = $"Day of Week: {dayOfWeek}\n" +
                              $"Month: {month}\n" +
                              $"Day of Month: {dayOfMonth}\n" +
                              $"Year: {year}";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // 1. Sifee dhammaan TextBox-yada ku jira foomka
            dayOfWeekTextBox.Clear();
            monthTextBox.Clear();
            dayOfMonthTextBox.Clear();
            yearTextBox.Clear();

            // 2. Masax qoraalka ku jira Label-ka output-ka
            dateOutputLabel.Text = "";
        }



    }
        }
    


