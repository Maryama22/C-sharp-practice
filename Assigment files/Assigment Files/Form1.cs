using System.IO;

namespace Assigment_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Which Import Class
            //StreamWriter Class - Use writing the file
            StreamWriter fileWriter;

            //Open the file - Creating a new file
            fileWriter = File.CreateText("modules.txt");

            //Process the file - Writing the file
            fileWriter.WriteLine("modules of this semester");
            fileWriter.WriteLine("Web Development");
            fileWriter.WriteLine("Database Systems");
            fileWriter.WriteLine("Operating System");
            fileWriter.WriteLine("Mathematics");
            fileWriter.WriteLine("Arabic");

            //Close the file - Using close function
            fileWriter.Close();
        }

        // ==== Reading Other Function =====
        private void btnReader_Click(object sender, EventArgs e)
        {
            //Hubi in file-ku jiro
            if (!File.Exists("modules.txt"))
            {
                MessageBox.Show("File not found, dib u fur program-ka");
                return;
            }

            //Clear the list box first, so items are not repeated
            OutputList.Items.Clear();

            //Which Import Class
            //StreamReader Class - Use reading the file
            StreamReader reader;

            //Open the file - Creating connection file and program
            reader = File.OpenText("modules.txt");

            //Process the file - Reading the file
            //Peek() = weli xaraf ma hadhay? (-1 = file-ku wuu dhammaaday)
            while (reader.Peek() != -1)
            {
                //ReadLine() akhriyaa hal line, ListBox-na ku darayaa
                OutputList.Items.Add(reader.ReadLine());
            }

            //Close the file - waa in la xidhaa ka hor Delete
            reader.Close();
        }

        // =====  Deleting the File =====
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Hubi in file-ku jiro
            if (!File.Exists("modules.txt"))
            {
                MessageBox.Show("File not found, dib u fur program-ka");
                return;
            }

            //Marka hore backup ka samee
            //true = haddii backup hore u jiray, beddel
            File.Copy("modules.txt", "modules_backup.txt", true);

            //Kadib file-ka asalka ah tirtir
            File.Delete("modules.txt");

            //ListBox-ka nadiifi
            OutputList.Items.Clear();

            MessageBox.Show("file deleted, backup waa la sameeyay");
        }

        // ===== BUTTON 3: Delete The Items File =====
        private void btnDeleteItems_Click(object sender, EventArgs e)
        {
            //Hubi in file-ku jiro
            if (!File.Exists("modules.txt"))
            {
                MessageBox.Show("File not found, dib u fur program-ka");
                return;
            }

            //Hubi in item la doortay (-1 = waxba lama dooran)
            if (OutputList.SelectedIndex == -1)
            {
                MessageBox.Show("Dooro item marka hore");
                return;
            }

            //Step 1: Item-ka ka tir ListBox-ka (RemoveAt + SelectedIndex)
            OutputList.Items.RemoveAt(OutputList.SelectedIndex);

            //Step 2: File-ka dib u samee
            StreamWriter fileWriter;
            fileWriter = File.CreateText("modules.txt");

            //Step 3: Items-ka hadhay ku qor file-ka
            foreach (object oneItem in OutputList.Items)
            {
                fileWriter.WriteLine(oneItem.ToString());
            }

            //Step 4: Xir file-ka
            fileWriter.Close();

            MessageBox.Show("item deleted");
        }
    }
}