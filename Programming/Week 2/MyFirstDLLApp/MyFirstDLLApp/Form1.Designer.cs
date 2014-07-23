namespace MyFirstDLLApp {
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
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnDivide = new System.Windows.Forms.Button();
      this.txtA = new System.Windows.Forms.TextBox();
      this.txtB = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(12, 64);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(94, 42);
      this.btnAdd.TabIndex = 0;
      this.btnAdd.Text = "Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnDivide
      // 
      this.btnDivide.Location = new System.Drawing.Point(113, 64);
      this.btnDivide.Name = "btnDivide";
      this.btnDivide.Size = new System.Drawing.Size(94, 42);
      this.btnDivide.TabIndex = 1;
      this.btnDivide.Text = "Divide";
      this.btnDivide.UseVisualStyleBackColor = true;
      this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
      // 
      // txtA
      // 
      this.txtA.Location = new System.Drawing.Point(33, 12);
      this.txtA.Name = "txtA";
      this.txtA.Size = new System.Drawing.Size(173, 20);
      this.txtA.TabIndex = 2;
      // 
      // txtB
      // 
      this.txtB.Location = new System.Drawing.Point(33, 38);
      this.txtB.Name = "txtB";
      this.txtB.Size = new System.Drawing.Size(173, 20);
      this.txtB.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(17, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "A:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 38);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(17, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "B:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(219, 114);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtB);
      this.Controls.Add(this.txtA);
      this.Controls.Add(this.btnDivide);
      this.Controls.Add(this.btnAdd);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnDivide;
    private System.Windows.Forms.TextBox txtA;
    private System.Windows.Forms.TextBox txtB;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}

