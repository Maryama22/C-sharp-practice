namespace Assigment_One
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void lbldepartment_Click(object sender, EventArgs e)
        {

        }

        private void btnshowinfo_Click(object sender, EventArgs e)


        {

            string studentName = txtname.Text;
            string department = txtdepartment.Text;
            string semester = txtsemester.Text;


            int studentId = int.Parse(txtstudentid.Text);

            lbloutput.Text = $"Student Name: {studentName}\n" +
                             $"Student ID: {studentId}\n" +
                             $"Department: {department}\n" +
                             $"Semester: {semester}";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            {
                txtname.Clear();
                txtstudentid.Clear();
                txtdepartment.Clear();
                txtsemester.Clear();

                lbloutput.Text = "";

                txtname.Focus();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

