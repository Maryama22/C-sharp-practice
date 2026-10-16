namespace Assigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = StudentTextBox.Text.Trim();

                if (name == "" || name.Any(char.IsDigit))
                {
                    MessageBox.Show("Fadlan magaca sax ah geli, nambar lama oggola!");
                }
                else
                {
                    if (!int.TryParse(StudentIDTextBox.Text.Trim(), out int studentId))
                    {
                        MessageBox.Show("Fadlan ID-ga geli nambar oo kaliya, xaraf lama oggola!");
                    }
                    else
                    {
                        int numCourses = int.Parse(NumberTextBox.Text);

                        if (numCourses < 1 || numCourses > 8)
                        {
                            MessageBox.Show("Tirada koorsadu waa inay noqotaa int u dhaxaysa 1 iyo 8!");
                        }
                        else
                        {
                            // 4. Hubinta Heerka Waxbarashada
                            int studyLevel = int.Parse(StudyTextBox.Text);

                            if (studyLevel < 1 || studyLevel > 4)
                            {
                                MessageBox.Show("Fadlan geli heerka waxbarashada 1 ilaa 4!");
                            }
                            else
                            {
                                // Xisaabinta lacagta koorsada
                                decimal fee = 0;
                                if (studyLevel == 1) fee = 40;
                                else if (studyLevel == 2) fee = 45;
                                else if (studyLevel == 3) fee = 50;
                                else if (studyLevel == 4) fee = 55;

                                decimal tuition = numCourses * fee;

                                decimal trans = 0;
                                if (TransportTextBox.Text != "")
                                {
                                    trans = 50;
                                }

                                decimal total = tuition + trans;

                                // Qiimo dhimis (Discount)
                                decimal discRate = 0;

                                if (numCourses >= 6)
                                {
                                    discRate = discRate + 0.10m;
                                }

                                decimal discountAmount = total * discRate;
                                decimal finalTotal = total - discountAmount;



                                // Ku soo bandhigida DisplayLabel
                                DisplayLabel.Text = "Name: " + name + "\n" +
                                                    "ID: " + StudentIDTextBox+ "\n" +
                                                    "Number Courses: " + numCourses.ToString() + "\n" +
                                                    "Study year: " + studyLevel.ToString() + "\n" +
                                                    "Transport Fee : " + trans.ToString("C0") + "\n" +
                                                    "Discount : " + discountAmount.ToString("C0") + "\n" +
                                                    "Tuition fee : " + tuition.ToString("C0") + "\n" +
                                                    "Final Amount : " + finalTotal.ToString("C0");
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fadlan hubi xogta aad gelisay oo geli nambarro sax ah!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            StudentTextBox.Text = "";
            StudentIDTextBox.Text = "";
            NumberTextBox.Text = "";
            StudyTextBox.Text = "";
            TransportTextBox.Text = "";


            DisplayLabel.Text = "";

            StudentTextBox.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
