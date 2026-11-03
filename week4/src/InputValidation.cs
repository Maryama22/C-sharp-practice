using System;
using System.Drawing;
using System.Windows.Forms;

class InputValidation : Form
{
    TextBox hoursTextBox; Label statusLabel;
    InputValidation()
    {
        Text = "Input Validation - Hours Worked"; ClientSize = new Size(420, 200);
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false;
        StartPosition = FormStartPosition.Manual; Location = new Point(40, 40);
        UI.L(this, "Hours worked this week:", 20, 28, 190); hoursTextBox = UI.T(this, 230, 25, 150);
        UI.L(this, "Result:", 20, 68, 80); statusLabel = UI.Out(this, 20, 92, 380, 28);
        Button b = UI.B(this, "Validate", 80, 140, 110); Button c = UI.B(this, "Clear", 220, 140, 110);
        b.Click += delegate
        {
            int hours;
            if (int.TryParse(hoursTextBox.Text, out hours))
            {
                if (hours > 0 && hours <= 168)
                {
                    statusLabel.ForeColor = Color.DarkGreen;
                    statusLabel.Text = "Valid: " + hours + " hours accepted.";
                }
                else
                {
                    statusLabel.ForeColor = Color.Firebrick;
                    statusLabel.Text = "Hours must be between 1 and 168.";
                }
            }
            else
            {
                statusLabel.ForeColor = Color.Firebrick;
                statusLabel.Text = "Not a number (TryParse failed).";
            }
        };
        c.Click += delegate { hoursTextBox.Clear(); statusLabel.Text = ""; };
        string[] a = Environment.GetCommandLineArgs();
        if (a.Length >= 2) { hoursTextBox.Text = a[1]; Shown += delegate { b.PerformClick(); }; }
    }
    static void Main() { Application.Run(new InputValidation()); }
}
