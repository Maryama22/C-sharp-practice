using System;
using System.Drawing;
using System.Windows.Forms;

class SwitchDemo : Form
{
    TextBox dayTextBox; Label dayNameLabel;
    SwitchDemo()
    {
        Text = "switch Statement - Day Name"; ClientSize = new Size(420, 200);
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false;
        StartPosition = FormStartPosition.Manual; Location = new Point(40, 40);
        UI.L(this, "Enter a day number (1-7):", 20, 28, 200); dayTextBox = UI.T(this, 240, 25, 140);
        UI.L(this, "Day name:", 20, 68, 100); dayNameLabel = UI.Out(this, 20, 92, 380, 28);
        Button b = UI.B(this, "Show Day", 80, 140, 110); Button c = UI.B(this, "Clear", 220, 140, 110);
        b.Click += delegate
        {
            int day;
            if (!int.TryParse(dayTextBox.Text, out day)) { dayNameLabel.Text = "Please enter a number."; return; }
            switch (day)
            {
                case 1: dayNameLabel.Text = "Monday"; break;
                case 2: dayNameLabel.Text = "Tuesday"; break;
                case 3: dayNameLabel.Text = "Wednesday"; break;
                case 4: dayNameLabel.Text = "Thursday"; break;
                case 5: dayNameLabel.Text = "Friday"; break;
                case 6: dayNameLabel.Text = "Saturday"; break;
                case 7: dayNameLabel.Text = "Sunday"; break;
                default: dayNameLabel.Text = "Invalid day number (use 1-7)."; break;
            }
        };
        c.Click += delegate { dayTextBox.Clear(); dayNameLabel.Text = ""; };
        string[] a = Environment.GetCommandLineArgs();
        if (a.Length >= 2) { dayTextBox.Text = a[1]; Shown += delegate { b.PerformClick(); }; }
    }
    static void Main() { Application.Run(new SwitchDemo()); }
}
