using System;
using System.Drawing;
using System.Windows.Forms;

class RadioCheck : Form
{
    RadioButton footballRadioButton, basketballRadioButton, baseballRadioButton;
    CheckBox pepperoniCheckBox, cheeseCheckBox, anchoviesCheckBox;
    Label resultLabel;
    RadioCheck()
    {
        Text = "RadioButton and CheckBox"; ClientSize = new Size(460, 270);
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false;
        StartPosition = FormStartPosition.Manual; Location = new Point(40, 40);
        GroupBox g1 = new GroupBox(); g1.Text = "Select Your Favorite Sport";
        g1.Location = new Point(15, 15); g1.Size = new Size(205, 130); Controls.Add(g1);
        footballRadioButton = Radio(g1, "Football", 20, 30);
        basketballRadioButton = Radio(g1, "Basketball", 20, 60);
        baseballRadioButton = Radio(g1, "Baseball", 20, 90);
        footballRadioButton.Checked = true;
        GroupBox g2 = new GroupBox(); g2.Text = "Select Your Pizza Toppings";
        g2.Location = new Point(240, 15); g2.Size = new Size(205, 130); Controls.Add(g2);
        pepperoniCheckBox = Check(g2, "Pepperoni", 20, 30);
        cheeseCheckBox = Check(g2, "Cheese", 20, 60);
        anchoviesCheckBox = Check(g2, "Anchovies", 20, 90);
        UI.L(this, "Selection:", 15, 160, 100);
        resultLabel = UI.Out(this, 15, 185, 430, 50);
        resultLabel.TextAlign = ContentAlignment.TopLeft;
        Update2();
        string[] a = Environment.GetCommandLineArgs();
        if (a.Length >= 3)
        {
            Shown += delegate
            {
                if (a[1] == "basketball") basketballRadioButton.Checked = true;
                if (a[1] == "baseball") baseballRadioButton.Checked = true;
                if (a[2].Contains("p")) pepperoniCheckBox.Checked = true;
                if (a[2].Contains("c")) cheeseCheckBox.Checked = true;
                if (a[2].Contains("a")) anchoviesCheckBox.Checked = true;
            };
        }
    }
    RadioButton Radio(Control p, string t, int x, int y)
    {
        RadioButton r = new RadioButton(); r.Text = t; r.Location = new Point(x, y); r.Size = new Size(150, 24);
        r.CheckedChanged += delegate { Update2(); }; p.Controls.Add(r); return r;
    }
    CheckBox Check(Control p, string t, int x, int y)
    {
        CheckBox c = new CheckBox(); c.Text = t; c.Location = new Point(x, y); c.Size = new Size(150, 24);
        c.CheckedChanged += delegate { Update2(); }; p.Controls.Add(c); return c;
    }
    void Update2()
    {
        if (resultLabel == null) return;
        string sport = "";
        if (footballRadioButton.Checked) sport = "Football";
        else if (basketballRadioButton.Checked) sport = "Basketball";
        else if (baseballRadioButton.Checked) sport = "Baseball";
        string toppings = "";
        if (pepperoniCheckBox.Checked) toppings += "Pepperoni ";
        if (cheeseCheckBox.Checked) toppings += "Cheese ";
        if (anchoviesCheckBox.Checked) toppings += "Anchovies ";
        if (toppings == "") toppings = "(none)";
        resultLabel.Text = "Favorite sport: " + sport + "\nToppings: " + toppings;
    }
    static void Main() { Application.Run(new RadioCheck()); }
}
