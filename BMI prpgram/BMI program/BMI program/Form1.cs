namespace BMI_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declaring varibales
            double Weight;
            double Height;
            double BMI;

            try
            {
                Weight = double.Parse(txtWeight.Text);
                Height = double.Parse(txtHeight.Text);
                //check if the user input a string
                if (double.TryParse(txtWeight.Text, out Weight) && Weight > 0)
                {
                    if (double.TryParse(txtHeight.Text, out Height) && Height > 0)
                    {
                        //formula of BMI
                        BMI = Weight / (Height * Height);
                        //check BMI
                        if (BMI < 18.5)
                        {
                            MessageBox.Show("underWeight");
                        }
                        else if (BMI >= 18.5 && BMI <= 25)
                        {
                            MessageBox.Show("optimal weight");
                        }
                        else if (BMI > 25)
                        {
                            MessageBox.Show("overWeight");
                        }
                        //display result
                        listResult.Items.Add("your weigh is:" + Weight);
                        listResult.Items.Add("your height is :" + Height);
                        listResult.Items.Add("BMI:" + BMI.ToString("F2"));
                    }
                    else
                    {
                        MessageBox.Show("invalid input! please enter a numeric value");
                    }
                }
                else
                {
                    MessageBox.Show("invalid input! please enter a numeric value");
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();
            txtWeight.Clear();
            txtHeight.Clear();
            

        }
    }
}
