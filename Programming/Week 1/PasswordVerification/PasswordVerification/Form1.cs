using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordVerification {
  public partial class Form1 : Form {

    PasswordVerification pass;
    private int attempts;
    readonly int maxAttempts = 3;

    public Form1() {
      this.pass = new PasswordVerification("george", "test");
      InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e) {

      string name = this.txtName.Text;
      string password = this.txtPassword.Text;
      bool isCorrect = this.pass.IsPasswordCorrect(name, password);

      if (isCorrect) {
        MessageBox.Show("That is correct!");
        this.attempts = 0;
      } else {
        this.attempts++;
        MessageBox.Show(string.Format("That is incorrect. {0} attempts left",
          this.maxAttempts - this.attempts));
      }

      this.txtPassword.Text = "";

      if (this.attempts >= this.maxAttempts) {
        this.Close();
      }

    }

  }
}
