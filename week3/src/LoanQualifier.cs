using System;
using System.Drawing;
using System.Windows.Forms;

class LoanQualifier : Form
{
    TextBox salaryTextBox, yearsTextBox;
    Label decisionLabel;

    LoanQualifier()
    {
        Text = "Loan Qualifier"; ClientSize = new Size(420, 250);
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false;
        StartPosition = FormStartPosition.Manual; Location = new Point(40, 40);
        UI.L(this, "Annual Salary :", 20, 23, 130); salaryTextBox = UI.T(this, 200, 20, 190);
        UI.L(this, "Years at current job :", 20, 63, 170); yearsTextBox = UI.T(this, 200, 60, 190);
        UI.L(this, "Loan Decision", 20, 103, 120);
        decisionLabel = UI.Out(this, 20, 128, 370, 28);
        Button checkButton = UI.B(this, "Check Qualification", 40, 180, 130, 45);
        Button clearButton = UI.B(this, "Clear", 190, 180, 90);
        Button exitButton = UI.B(this, "Exit", 295, 180, 90);
        checkButton.Click += delegate { Check(); };
        clearButton.Click += delegate { salaryTextBox.Clear(); yearsTextBox.Clear(); decisionLabel.Text = ""; };
        exitButton.Click += delegate { Close(); };
        string[] a = Environment.GetCommandLineArgs();
        if (a.Length >= 3)
        {
            salaryTextBox.Text = a[1]; yearsTextBox.Text = a[2];
            Shown += delegate { checkButton.PerformClick(); };
        }
    }

    void Check()
    {
        double salary, yearsOnJob;
        if (double.TryParse(salaryTextBox.Text, out salary) && double.TryParse(yearsTextBox.Text, out yearsOnJob))
        {
            if (salary >= 40000)
            {
                if (yearsOnJob >= 2)
                    decisionLabel.Text = "You qualify for the loan.";
                else
                    decisionLabel.Text = "Minimum years at current job not met.";
            }
            else
            {
                decisionLabel.Text = "Minimum salary requirement not met.";
            }
        }
        else decisionLabel.Text = "Please enter valid numbers.";
    }

    static void Main() { Application.Run(new LoanQualifier()); }
}
