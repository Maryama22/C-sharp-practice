using System;
using System.Drawing;
using System.Windows.Forms;

class ListBoxDemo : Form
{
    ListBox daysListBox; Label infoLabel;
    ListBoxDemo()
    {
        Text = "ListBox Demo"; ClientSize = new Size(440, 290);
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false;
        StartPosition = FormStartPosition.Manual; Location = new Point(40, 40);
        daysListBox = new ListBox(); daysListBox.Location = new Point(20, 20); daysListBox.Size = new Size(150, 150);
        Controls.Add(daysListBox);
        Button add = UI.B(this, "Add Days", 195, 20, 220); Button remove = UI.B(this, "Remove Tuesday", 195, 60, 220);
        Button removeAt = UI.B(this, "RemoveAt(2)", 195, 100, 220); Button clear = UI.B(this, "Clear", 195, 140, 220);
        infoLabel = UI.Out(this, 20, 190, 400, 80); infoLabel.TextAlign = ContentAlignment.TopLeft;
        daysListBox.SelectedIndexChanged += delegate { ShowInfo(); };
        add.Click += delegate
        {
            daysListBox.Items.Add("Monday"); daysListBox.Items.Add("Tuesday");
            daysListBox.Items.Add("Wednesday"); daysListBox.Items.Add("Thursday"); daysListBox.Items.Add("Friday");
            ShowInfo();
        };
        remove.Click += delegate { daysListBox.Items.Remove("Tuesday"); ShowInfo(); };
        removeAt.Click += delegate
        {
            if (daysListBox.Items.Count > 2) daysListBox.Items.RemoveAt(2);
            ShowInfo();
        };
        clear.Click += delegate { daysListBox.Items.Clear(); ShowInfo(); };
        string[] a = Environment.GetCommandLineArgs();
        if (a.Length >= 2)
        {
            Shown += delegate
            {
                add.PerformClick();
                if (a[1] == "removed") remove.PerformClick();
                if (a[1] == "selected") daysListBox.SelectedIndex = 2;
            };
        }
        ShowInfo();
    }
    void ShowInfo()
    {
        string sel;
        if (daysListBox.SelectedIndex != -1) sel = daysListBox.SelectedItem.ToString();
        else sel = "(no item selected)";
        infoLabel.Text = "Total items: " + daysListBox.Items.Count + "\nSelectedIndex: " + daysListBox.SelectedIndex +
                         "\nSelectedItem: " + sel;
    }
    static void Main() { Application.Run(new ListBoxDemo()); }
}
