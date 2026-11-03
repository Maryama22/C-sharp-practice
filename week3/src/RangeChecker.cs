using System;
using System.Drawing;
using System.Windows.Forms;

class RangeChecker : Form
{
    TextBox numberTextBox;
    Label decisionLabel;

    RangeChecker()
    {
        Text = "Range_Checker"; ClientSize = new Size(440, 270);
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false;
        StartPosition = FormStartPosition.Manual; Location = new Point(40, 40);
        Label t = UI.L(this, "Range Checker Application", 20, 15, 400, 24);
        t.Font = new Font(Font.FontFamily, 11f);
        UI.L(this, "Enter an integer in the range of 1 through 10", 20, 48, 400, 22);
        numberTextBox = UI.T(this, 140, 80, 160);
        UI.L(this, "Range Decision", 160, 120, 120);
        decisionLabel = UI.Out(this, 20, 145, 400, 28);
        Button checkButton = UI.B(this, "Check Range", 40, 195, 120, 45);
        Button clearButton = UI.B(this, "Clear", 190, 195, 100);
        Button exitButton = UI.B(this, "Exit", 310, 195, 100);
        checkButton.Click += delegate { Check(); };
        clearButton.Click += delegate { numberTextBox.Clear(); decisionLabel.Text = ""; };
        exitButton.Click += delegate { Close(); };
        string[] a = Environment.GetCommandLineArgs();
        if (a.Length >= 2) { numberTextBox.Text = a[1]; Shown += delegate { checkButton.PerformClick(); }; }
    }

    void Check()
    {
        int number;
        if (int.TryParse(numberTextBox.Text, out number))
        {
            if (number >= 1 && number <= 10)
                decisionLabel.Text = "The number is in the range.";
            else
                decisionLabel.Text = "The number is NOT in the range.";
        }
        else decisionLabel.Text = "Please enter an integer.";
    }

    static void Main() { Application.Run(new RangeChecker()); }
}
