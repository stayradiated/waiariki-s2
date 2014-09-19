namespace ClockTimezones {
  partial class ClockTimezones {
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.btn_cancel = new System.Windows.Forms.Button();
        this.btn_apply = new System.Windows.Forms.Button();
        this.comboBox = new System.Windows.Forms.ComboBox();
        this.clock = new ClockControl.ClockControl();
        this.tableLayoutPanel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 2;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel1.Controls.Add(this.btn_cancel, 0, 2);
        this.tableLayoutPanel1.Controls.Add(this.btn_apply, 1, 2);
        this.tableLayoutPanel1.Controls.Add(this.comboBox, 0, 1);
        this.tableLayoutPanel1.Controls.Add(this.clock, 0, 0);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 3;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
        this.tableLayoutPanel1.Size = new System.Drawing.Size(319, 405);
        this.tableLayoutPanel1.TabIndex = 0;
        // 
        // btn_cancel
        // 
        this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btn_cancel.Location = new System.Drawing.Point(3, 368);
        this.btn_cancel.Name = "btn_cancel";
        this.btn_cancel.Size = new System.Drawing.Size(153, 34);
        this.btn_cancel.TabIndex = 0;
        this.btn_cancel.Text = "&Cancel";
        this.btn_cancel.UseVisualStyleBackColor = true;
        this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
        // 
        // btn_apply
        // 
        this.btn_apply.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btn_apply.Location = new System.Drawing.Point(162, 368);
        this.btn_apply.Name = "btn_apply";
        this.btn_apply.Size = new System.Drawing.Size(154, 34);
        this.btn_apply.TabIndex = 1;
        this.btn_apply.Text = "&Apply";
        this.btn_apply.UseVisualStyleBackColor = true;
        this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
        // 
        // comboBox
        // 
        this.tableLayoutPanel1.SetColumnSpan(this.comboBox, 2);
        this.comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
        this.comboBox.FormattingEnabled = true;
        this.comboBox.Location = new System.Drawing.Point(3, 328);
        this.comboBox.Name = "comboBox";
        this.comboBox.Size = new System.Drawing.Size(313, 21);
        this.comboBox.TabIndex = 2;
        // 
        // clock
        // 
        this.tableLayoutPanel1.SetColumnSpan(this.clock, 2);
        this.clock.Dock = System.Windows.Forms.DockStyle.Fill;
        this.clock.Location = new System.Drawing.Point(3, 3);
        this.clock.MinimumSize = new System.Drawing.Size(50, 50);
        this.clock.Name = "clock";
        this.clock.Size = new System.Drawing.Size(313, 319);
        this.clock.TabIndex = 3;
        this.clock.Text = " ";
        this.clock.TimeZoneOffset = 0D;
        this.clock.Load += new System.EventHandler(this.clockControl1_Load);
        // 
        // ClockTimezones
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.tableLayoutPanel1);
        this.Name = "ClockTimezones";
        this.Size = new System.Drawing.Size(319, 405);
        this.tableLayoutPanel1.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button btn_cancel;
    private System.Windows.Forms.Button btn_apply;
    private System.Windows.Forms.ComboBox comboBox;
    private ClockControl.ClockControl clock;
  }
}
