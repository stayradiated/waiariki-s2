using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace StatefulForm {

  public partial class Form1 : Form {

    private string PATH;

    public Form1() {
      InitializeComponent();

      this.PATH = Path.Combine(Application.StartupPath, "FormStateInfo.dat");

      // Restore the form's position and size from the state file if it exists.

      if (File.Exists(this.PATH) == true) {
        StreamReader sr = new StreamReader(this.PATH);

        int x = int.Parse(sr.ReadLine());
        int y = int.Parse(sr.ReadLine());
        int w = int.Parse(sr.ReadLine());
        int h = int.Parse(sr.ReadLine());

        this.Location = new Point(x, y);
        this.Width = w;
        this.Height = h;

        txtDetails.Text = string.Format("X: {0}, Y: {1}, W: {2}, H: {3}",
          x, y, w, h);

        sr.Close();
      }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
      StreamWriter sw = new StreamWriter(this.PATH);
      sw.WriteLine(this.Location.X.ToString());
      sw.WriteLine(this.Location.Y.ToString());
      sw.WriteLine(this.Width.ToString());
      sw.WriteLine(this.Height.ToString());
      sw.Close();
    }

  }
}
