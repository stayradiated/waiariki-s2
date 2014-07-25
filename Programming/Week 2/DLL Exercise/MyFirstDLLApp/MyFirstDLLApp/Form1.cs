using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyFirstDLLApp {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e) {
      int a = Int32.Parse(this.txtA.Text);
      int b = Int32.Parse(this.txtB.Text);
      MessageBox.Show(MyFirstDLL.MyClass.AddTwo(a, b).ToString());
    }

    private void btnDivide_Click(object sender, EventArgs e) {
      double a = Double.Parse(this.txtA.Text);
      double b = Double.Parse(this.txtB.Text);
      MessageBox.Show(MyFirstDLL.MyClass.DivTwo(a, b).ToString());
    }

  }
}
