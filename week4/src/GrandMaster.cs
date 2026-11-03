using System;
using System.Drawing;
using System.Windows.Forms;

class GrandMaster : Form
{
    TextBox txtPoints; Label lblResult;
    GrandMaster()
    {
        Text = "Grand Master Flag"; ClientSize = new Size(380, 190);
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false;
        StartPosition = FormStartPosition.Manual; Location = new Point(40, 40);
        UI.L(this, "Points earned:", 25, 28, 120); txtPoints = UI.T(this, 170, 25, 170);
        UI.L(this, "isGrandMaster:", 25, 68, 130); lblResult = UI.Out(this, 170, 65, 170);
        Button b = UI.B(this, "Check", 60, 120, 110); Button c = UI.B(this, "Clear", 200, 120, 110);
        b.Click += delegate
        {
            double points; bool isGrandMaster;
            if (double.TryParse(txtPoints.Text, out points))
            {
                if (points > 5000) { isGrandMaster = true; } else { isGrandMaster = false; }
                lblResult.Text = isGrandMaster.ToString();
            }
            else lblResult.Text = "Invalid number";
        };
        c.Click += delegate { txtPoints.Clear(); lblResult.Text = ""; };
        string[] a = Environment.GetCommandLineArgs();
        if (a.Length >= 2) { txtPoints.Text = a[1]; Shown += delegate { b.PerformClick(); }; }
    }
    static void Main() { Application.Run(new GrandMaster()); }
}
