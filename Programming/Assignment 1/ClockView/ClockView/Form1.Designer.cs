namespace ClockView {
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
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.clockTimezones1 = new ClockTimezones.ClockTimezones();
        this.clockTimezones2 = new ClockTimezones.ClockTimezones();
        this.clockTimezones3 = new ClockTimezones.ClockTimezones();
        this.clockTimezones4 = new ClockTimezones.ClockTimezones();
        this.tableLayoutPanel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 2;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel1.Controls.Add(this.clockTimezones1, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.clockTimezones2, 1, 0);
        this.tableLayoutPanel1.Controls.Add(this.clockTimezones3, 0, 1);
        this.tableLayoutPanel1.Controls.Add(this.clockTimezones4, 1, 1);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 2;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 520);
        this.tableLayoutPanel1.TabIndex = 0;
        // 
        // clockTimezones1
        // 
        this.clockTimezones1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.clockTimezones1.Location = new System.Drawing.Point(3, 3);
        this.clockTimezones1.Name = "clockTimezones1";
        this.clockTimezones1.Size = new System.Drawing.Size(277, 254);
        this.clockTimezones1.TabIndex = 0;
        // 
        // clockTimezones2
        // 
        this.clockTimezones2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.clockTimezones2.Location = new System.Drawing.Point(286, 3);
        this.clockTimezones2.Name = "clockTimezones2";
        this.clockTimezones2.Size = new System.Drawing.Size(277, 254);
        this.clockTimezones2.TabIndex = 1;
        // 
        // clockTimezones3
        // 
        this.clockTimezones3.Dock = System.Windows.Forms.DockStyle.Fill;
        this.clockTimezones3.Location = new System.Drawing.Point(3, 263);
        this.clockTimezones3.Name = "clockTimezones3";
        this.clockTimezones3.Size = new System.Drawing.Size(277, 254);
        this.clockTimezones3.TabIndex = 2;
        // 
        // clockTimezones4
        // 
        this.clockTimezones4.Dock = System.Windows.Forms.DockStyle.Fill;
        this.clockTimezones4.Location = new System.Drawing.Point(286, 263);
        this.clockTimezones4.Name = "clockTimezones4";
        this.clockTimezones4.Size = new System.Drawing.Size(277, 254);
        this.clockTimezones4.TabIndex = 3;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(566, 520);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Name = "Form1";
        this.Text = "Form1";
        this.tableLayoutPanel1.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private ClockTimezones.ClockTimezones clockTimezones1;
    private ClockTimezones.ClockTimezones clockTimezones2;
    private ClockTimezones.ClockTimezones clockTimezones3;
    private ClockTimezones.ClockTimezones clockTimezones4;

  }
}

