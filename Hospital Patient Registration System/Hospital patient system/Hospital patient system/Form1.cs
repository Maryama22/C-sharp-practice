namespace Hospital_patient_system
{
    public partial class Form1 : Form
    {
        private const string FILE = "patient.tx";
        public Form1()
        {
            InitializeComponent();



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            if (patientIdtx.Text == "" || patientNametx.Text == "" || patientAgetx.Text == "")
            {
                MessageBox.Show("Fadlan buuxi dhammaan macluumaadka.");
                return;
            }

            if (!maleRadio.Checked && !femaleRadio.Checked)
            {
                MessageBox.Show("Fadlan dooro jinsiga.");
                return;
            }

            string gender = "";
            if (maleRadio.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }



            string record = patientIdtx.Text + " - " + patientNametx.Text + " - " + patientAgetx.Text + " - " + gender;

            StreamWriter outputFile = File.AppendText(record);
            outputFile.WriteLine(record);
            outputFile.Close();

            patientListBox.Items.Add(record);


        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
           
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Filter = "Text files (.txt)|.txt|All files (.)|.";
                openDialog.Title = "Dooro faylka bukaanka";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    patientListBox.Items.Clear();

                    StreamReader inputFile = File.OpenText(openDialog.FileName);

                    while (inputFile.EndOfStream == false)
                    {
                        string line = inputFile.ReadLine();
                        patientListBox.Items.Add(line);
                    }

                    UpdateTotal();
                }
                patientListBox.Items.Clear();

                if (File.Exists(FILE))
                {
                    StreamReader inputFile = File.OpenText(FILE);

                    while (inputFile.EndOfStream == false)
                    {
                        string line = inputFile.ReadLine();
                        patientListBox.Items.Add(line);
                    }

                    inputFile.Close();
                }

            }
        

        private void removebutton_Click(object sender, EventArgs e)
        {
            if (patientListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Marka hore diiwaan dooro.");
            }
            // Qor dhammaan liiska faylka dib u
            StreamWriter outputFile = File.CreateText(FILE);
            int count = 0;

            while (count < patientListBox.Items.Count)
            {
                outputFile.WriteLine(patientListBox.Items[count]);
                count++;
            }

        }
        private void UpdateTotal()
        {
            totalTx.Text = patientListBox.Items.Count.ToString();
        }

        private void countbutton_Click(object sender, EventArgs e)
        {

            UpdateTotal();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            patientNametx.Clear();
            patientIdtx.Clear();
            patientAgetx.Clear();
            totalTx.Clear();
            patientListBox.Items.Clear();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


