using System;
using System.Drawing;
using System.Windows.Forms;

class PayrollOvertime : Form
{
    TextBox hoursWorkedTextBox, hourlyPayRateTextBox;
    Label grossPayLabel, statusLabel;

    PayrollOvertime()
    {
        Text = "Payroll with Overtime"; ClientSize = new Size(380, 250);
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false;
        StartPosition = FormStartPosition.Manual; Location = new Point(40, 40);
        UI.L(this, "Hours worked:", 30, 28, 120); hoursWorkedTextBox = UI.T(this, 180, 25, 160);
        UI.L(this, "Hourly pay rate:", 30, 68, 130); hourlyPayRateTextBox = UI.T(this, 180, 65, 160);
        UI.L(this, "Gross pay:", 30, 108, 120); grossPayLabel = UI.Out(this, 180, 105, 160);
        statusLabel = UI.L(this, "", 30, 145, 320, 20); statusLabel.ForeColor = Color.Firebrick;
        Button calculateButton = UI.B(this, "Calculate Gross Pay", 20, 180, 120, 45);
        Button clearButton = UI.B(this, "Clear", 150, 187, 90);
        Button exitButton = UI.B(this, "Exit", 250, 187, 90);
        calculateButton.Click += delegate { Calculate(); };
        clearButton.Click += delegate
        {
            hoursWorkedTextBox.Clear(); hourlyPayRateTextBox.Clear();
            grossPayLabel.Text = ""; statusLabel.Text = "";
        };
        exitButton.Click += delegate { Close(); };
        string[] a = Environment.GetCommandLineArgs();
        if (a.Length >= 3)
        {
            hoursWorkedTextBox.Text = a[1]; hourlyPayRateTextBox.Text = a[2];
            Shown += delegate { calculateButton.PerformClick(); };
        }
    }

    void Calculate()
    {
        const decimal BASE_HOURS = 40m, OT_MULTIPLIER = 1.5m;
        decimal hours, rate, gross;
        statusLabel.Text = "";
        if (decimal.TryParse(hoursWorkedTextBox.Text, out hours) &&
            decimal.TryParse(hourlyPayRateTextBox.Text, out rate))
        {
            if (hours > BASE_HOURS)
                gross = (BASE_HOURS * rate) + ((hours - BASE_HOURS) * rate * OT_MULTIPLIER);
            else
                gross = hours * rate;
            grossPayLabel.Text = gross.ToString("c", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        }
        else { grossPayLabel.Text = ""; statusLabel.Text = "Please enter valid numbers."; }
    }

    static void Main() { Application.Run(new PayrollOvertime()); }
}
