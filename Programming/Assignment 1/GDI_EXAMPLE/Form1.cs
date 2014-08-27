using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace GDI_EXAMPLE {

  public partial class Form1 : Form {

    private Clockface clock;

    public Form1() {
      InitializeComponent();
      this.clock = new Clockface();
      this.DoubleBuffered = true;
      this.ResizeRedraw = true;
    }

    protected override void OnPaint(PaintEventArgs e) {
      RenderScene(e.Graphics);
      this.Invalidate();
    }

    public void RenderScene (Graphics graphics) {
      this.clock.Draw(graphics);
    }

  }

}