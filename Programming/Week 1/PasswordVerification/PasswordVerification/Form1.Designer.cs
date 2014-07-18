namespace PasswordVerification {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.btnLogin = new System.Windows.Forms.Button();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.txtName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnLogin
      // 
      this.btnLogin.Location = new System.Drawing.Point(77, 64);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(171, 49);
      this.btnLogin.TabIndex = 3;
      this.btnLogin.Text = "Login";
      this.btnLogin.UseVisualStyleBackColor = true;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(77, 38);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(171, 20);
      this.txtPassword.TabIndex = 2;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(77, 12);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(171, 20);
      this.txtName.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 23);
      this.label1.TabIndex = 4;
      this.label1.Text = "Name:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(12, 32);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(59, 23);
      this.label2.TabIndex = 5;
      this.label2.Text = "Password:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(260, 130);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.btnLogin);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

  }
}

