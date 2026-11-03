using System;
using System.Drawing;
using System.Windows.Forms;

class TestScoreAverage : Form
{
    TextBox test1TextBox, test2TextBox, test3TextBox;
    Label averageLabel;

    TestScoreAverage()
    {
        Form f = this;
        Text = "Test Score Average"; ClientSize = new Size(380, 290);
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false;
        StartPosition = FormStartPosition.Manual; Location = new Point(40, 40);
        GroupBox g = new GroupBox(); g.Text = "Enter Three Test Scores";
        g.Location = new Point(20, 15); g.Size = new Size(340, 160); Controls.Add(g);
        UI.L(g, "Test Score #1", 20, 33, 100); test1TextBox = UI.T(g, 140, 30, 170);
        UI.L(g, "Test Score #2", 20, 68, 100); test2TextBox = UI.T(g, 140, 65, 170);
        UI.L(g, "Test Score #3", 20, 103, 100); test3TextBox = UI.T(g, 140, 100, 170);
        UI.L(g, "Average", 20, 133, 100); averageLabel = UI.Out(g, 140, 128, 170, 22);
        Button calculateButton = UI.B(this, "Calculate Average", 60, 195, 130, 45);
        Button clearButton = UI.B(this, "Clear", 205, 195, 100, 30);
        Button exitButton = UI.B(this, "Exit", 205, 232, 100, 30);
        calculateButton.Click += delegate { Calculate(); };
        clearButton.Click += delegate
        {
            test1TextBox.Clear(); test2TextBox.Clear(); test3TextBox.Clear();
            averageLabel.Text = ""; test1TextBox.Focus();
        };
        exitButton.Click += delegate { Close(); };
        string[] a = Environment.GetCommandLineArgs();
        if (a.Length >= 4)
        {
            test1TextBox.Text = a[1]; test2TextBox.Text = a[2]; test3TextBox.Text = a[3];
            Shown += delegate { calculateButton.PerformClick(); };
        }
    }

    void Calculate()
    {
        const double HIGH_SCORE = 95.0;
        double test1, test2, test3, average;
        try
        {
            test1 = double.Parse(test1TextBox.Text);
            test2 = double.Parse(test2TextBox.Text);
            test3 = double.Parse(test3TextBox.Text);
            average = (test1 + test2 + test3) / 3.0;
            averageLabel.Text = average.ToString("n1");
            if (average > HIGH_SCORE)
                MessageBox.Show("Congratulations! Great job!");
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    static void Main() { Application.Run(new TestScoreAverage()); }
}
