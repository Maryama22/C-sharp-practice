using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace file_dialog_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // reading

            // import class
            StreamReader reader;

            DialogResult Result;
            Result = openFile.ShowDialog();
            if (Result == DialogResult.OK)
            {
                ListResult.Items.Clear();

                // open the file -- reading the file
                reader = File.OpenText(openFile.FileName);

                // process file
                string lines;
                // check 
                while (reader.EndOfStream == false)
                {
                    lines = reader.ReadLine();
                    ListResult.Items.Add(lines);
                }
                reader.Close();
            }
            else if (Result == DialogResult.Cancel)
            {
                MessageBox.Show("not open the file");
            }
        }

        private void openFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txlShow.Text))
            {
                MessageBox.Show("Fadlan wax ku qor TextBox-ka!");
                
            }

            DialogResult result;
            result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                // append si lo kaydiyo labada xogba
                using (StreamWriter writes = File.AppendText(saveFileDialog1.FileName))
                {
                    writes.WriteLine(txlShow.Text);
                }

                ListResult.Items.Add(txlShow.Text);

                txlShow.Clear();

                MessageBox.Show("Xogta waa la keydiyay!");
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("not saved the file");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ListResult.Items.Clear();
        }
    }
}