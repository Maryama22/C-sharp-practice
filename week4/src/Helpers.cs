using System;
using System.Drawing;
using System.Windows.Forms;

// Helper methods that build controls programmatically (so each lab is one simple .cs file).
static class UI
{
    public static Form Make(string title, int w, int h)
    {
        Form f = new Form();
        f.Text = title;
        f.ClientSize = new Size(w, h);
        f.FormBorderStyle = FormBorderStyle.FixedDialog;
        f.MaximizeBox = false;
        f.StartPosition = FormStartPosition.Manual;
        f.Location = new Point(40, 40);
        f.BackColor = SystemColors.Control;
        return f;
    }
    public static Label L(Control p, string t, int x, int y, int w = 150, int h = 20)
    {
        Label l = new Label(); l.Text = t; l.Location = new Point(x, y); l.Size = new Size(w, h);
        p.Controls.Add(l); return l;
    }
    public static TextBox T(Control p, int x, int y, int w = 120)
    {
        TextBox t = new TextBox(); t.Location = new Point(x, y); t.Size = new Size(w, 22);
        p.Controls.Add(t); return t;
    }
    public static Button B(Control p, string t, int x, int y, int w = 90, int h = 30)
    {
        Button b = new Button(); b.Text = t; b.Location = new Point(x, y); b.Size = new Size(w, h);
        p.Controls.Add(b); return b;
    }
    public static Label Out(Control p, int x, int y, int w, int h = 24)
    {
        Label l = new Label(); l.BorderStyle = BorderStyle.Fixed3D; l.BackColor = Color.White;
        l.TextAlign = ContentAlignment.MiddleLeft;
        l.Location = new Point(x, y); l.Size = new Size(w, h); p.Controls.Add(l); return l;
    }
}
