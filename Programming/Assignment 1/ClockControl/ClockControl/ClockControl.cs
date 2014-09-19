using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ClockControl {

  /*
   * Clock Control
   * =============
   *
   * A clock face that shows the current time in a specified timezone.
   */

  public partial class ClockControl : UserControl {

    /*
     * Constants
     * =========
     *
     * Colors and brushes used to draw the clockface.
     */

    private static Color HIGHLIGHT_COLOR  = Color.DarkRed;
    private static Color BACKGROUND_COLOR = Color.Black;
    private static Color FOREGROUND_COLOR = Color.White;

    private static Brush HIGHLIGHT_BRUSH  = new SolidBrush(HIGHLIGHT_COLOR);
    private static Brush BACKGROUND_BRUSH = new SolidBrush(BACKGROUND_COLOR);
    private static Brush FOREGROUND_BRUSH = new SolidBrush(FOREGROUND_COLOR);

    private static Pen SECONDHAND_PEN = new Pen(HIGHLIGHT_BRUSH, 1);
    private static Pen MINUTEHAND_PEN = new Pen(BACKGROUND_BRUSH, 3);
    private static Pen HOURHAND_PEN   = new Pen(BACKGROUND_BRUSH, 3);
    private static Pen MINUTEMARK_PEN = new Pen(BACKGROUND_BRUSH, 1);
    private static Pen HOURMARK_PEN   = new Pen(BACKGROUND_BRUSH, 3);

    /*
     * Private Variables
     * =================
     * 
     * Stores private information needed to draw the clock.
     */

    // current time
    private float seconds;
    private float minutes;
    private float hours;
    
    // timer
    private Timer timer;

    // store public variables
    private string text;
    private double timeZoneOffset;

    /*
     * Public Variables
     * ================
     * 
     * The stuff in square brackets is needed for these variables
     * to be displayed in the properties panel.
     * 
     * Found on a StackOverflow post:
     * http://stackoverflow.com/a/2881509
     */

    [EditorBrowsable(EditorBrowsableState.Always)]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Bindable(true)]
    
    // The text to display on the clockface 
    public override string Text {
      get { return this.text; }
      set { this.text = value; }
    }

    [EditorBrowsable(EditorBrowsableState.Always)]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Bindable(true)]

    // the timezone to run the clock in
    public double TimeZoneOffset {
      get { return this.timeZoneOffset; }
      set { this.timeZoneOffset = value; }
    }

    /*
     * Constructor
     * ===========
     * 
     * Create a new instance of the ClockControl.
     */

    public ClockControl() {
      // initialise private variables.
      this.text = "";
      this.timeZoneOffset = 0;
      this.seconds = 0;
      this.minutes = 0;
      this.hours = 0;

      // graphics options that improve perf
      this.DoubleBuffered = true;
      this.ResizeRedraw = true;

      // start a timer that runs the `tick` method every second.
      this.timer = new Timer();
      timer.Tick += new EventHandler(this.tick);
      timer.Interval = 16;
      timer.Start();

      // run the `tick` method immediately, so the UI doesn't lag
      // when you first run it.
      this.tick(null, null);
    }

    /*
     * Tick
     * ====
     * 
     * Recalcuates the current time and triggers a redraw of the clockface.
     */

    private void tick(Object o, EventArgs e) {
      // calculate time by adding timezone offset to UTC time.
      DateTime time = DateTime.UtcNow.AddHours(this.timeZoneOffset);

      // update seconds, minutes and hours variables.
      this.seconds = (time.Second / 60f);
      this.minutes = (time.Minute / 60f) + (this.seconds / 60f);
      this.hours = (time.Hour / 12f) + (this.minutes / 12f);

      // refresh the view (triggers OnPaint).
      this.Refresh();
    }

    /*
     * OnPaint
     * =======
     * 
     * Called whenever the view needs updating.
     */

    protected override void OnPaint(PaintEventArgs e) {
      // because we are overriding the default OnPaint method...
      base.OnPaint(e);

      // turn antialiasing on
      e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

      // draw the clock.
      this.Draw(e.Graphics);
    }

    /*
     * Draw
     * ====
     * 
     * Draws a clock.
     */

    public void Draw(Graphics graphics) {
      // create fonts for numbers and text.
      // has a dynamic font size so it can be resized.
      Font numbersFont = new Font("Arial", this.numbersFontSize, FontStyle.Regular);
      Font textFont = new Font("Arial", this.textFontSize, FontStyle.Regular);

      // draw the outer face (black) and the inner face (white)
      graphics.FillEllipse(BACKGROUND_BRUSH, this.outerFace);
      graphics.FillEllipse(FOREGROUND_BRUSH, this.innerFace);

      // draw the 60 minute marks around the edge of the clock
      for (float i = 0; i < 60; i++) {
        graphics.DrawLine(MINUTEMARK_PEN,
            this.position(i / 60, this.minuteMarkInnerRadius),
            this.position(i / 60, this.minuteMarkOuterRadius)
          );
      }

      // draw the text of on the clockface
      TextRenderer.DrawText(graphics, this.text, textFont, this.timeZonePosition, HIGHLIGHT_COLOR);

      // draw the second hand, minute hand and hour hand
      graphics.DrawLine(SECONDHAND_PEN, this.center, this.secondHand);
      graphics.DrawLine(MINUTEHAND_PEN, this.center, this.minuteHand);
      graphics.DrawLine(HOURHAND_PEN, this.center, this.hourHand);

      // draw the 12 hour marks and the 12 numbers
      for (int i = 1; i <= 12; i++) {
        float degrees = (float)i / 12f;
        graphics.DrawLine(HOURMARK_PEN,
          this.position(degrees, this.hourMarkInnerRadius),
          this.position(degrees, this.hourMarkOuterRadius)
        );
        Point position = this.position(degrees, this.fontRadius);
        position.Offset(-6, -6);
        graphics.DrawString(i.ToString(), numbersFont, BACKGROUND_BRUSH, position);
      }

      // draw the little black circle in the center
      graphics.FillEllipse(BACKGROUND_BRUSH, this.centerFace);
    }


    /*
     * Dynamic Clock Properties
     * ========================
     * 
     * Read-only.
     * Could improve performance by caching values.
     */

    // diameter of entire clockface (including border)
    private float diameter {
      get { return Math.Min(this.Size.Width, this.Size.Height); }
    }

    // radius of entire clockface (including border)
    private float radius {
      get { return this.diameter / 2f; }
    }

    // width of border
    private float borderWidth {
      get { return this.diameter / 50f; }
    }

    // radius of the little circle in the middle of the clock
    private float centerFaceRadius {
      get { return this.radius / 15; }
    }

    // length of hour hand
    private float hourHandRadius {
      get { return this.radius / 2f; }
    }

    // length of minute hand
    private float minuteHandRadius {
      get { return this.radius / 1.3f; }
    }

    // length of second hand
    private float secondHandRadius {
      get { return this.radius / 1.2f; }
    }

    // distance from center to outer edge of the 12 hour marks
    private float hourMarkOuterRadius {
      get { return this.radius / 1.1f; }
    }

    // distance from center to inner edge of the 12 hour marks
    private float hourMarkInnerRadius {
      get { return this.radius / 1.25f; }
    }

    // distance from center to outer edge of the 60 minute marks
    private float minuteMarkOuterRadius {
      get { return this.radius / 1.1f; }
    }

    // distance from center to inner edge of the 60 minute marks
    private float minuteMarkInnerRadius {
      get { return this.radius / 1.12f; }
    }

    // distance from center to top left edge of the 12 numbers
    private float fontRadius {
      get { return this.radius / 1.4f; }
    }

    // font size of the 12 numbers
    private int numbersFontSize {
      get { return (int)(this.radius / 10); }
    }

    // font size of the timezone text
    private int textFontSize {
      get { return (int)(this.radius / 13); }
    }

    /*
     * Points
     * ======
     * 
     * Read-only.
     * X and Y values.
     */

    // position of the center of the clockface
    private Point center {
      get {
        return new Point(
          (int)this.Size.Width/2,
          (int)this.Size.Height/2
        );
      }
    }

    // position of the second hand
    private Point secondHand {
      get { return this.position(this.seconds, this.secondHandRadius); }
    }

    // position of the minute hand
    private Point minuteHand {
      get { return this.position(this.minutes, this.minuteHandRadius); }
    }

    // position of the hour hand
    private Point hourHand {
      get { return this.position(this.hours, this.hourHandRadius); }
    }


    /*
     * Point Position Calculator
     * =========================
     *
     * Used to calculate a point on the clockface based on
     * - (float) degrees: A number between 0 and 1. 0 => 12:00, 0.5 => 6:00
     * - (float) radius: Distance in pixels from center of clockface
     *
     * Returned point is absolutely positioned. 
     */

    private Point position(float degrees, float radius) {
      Point point = new Point(
        (int)(radius * Math.Cos(degrees * 2 * Math.PI - (Math.PI / 2))),
        (int)(radius * Math.Sin(degrees * 2 * Math.PI - (Math.PI / 2)))
      );
      point.Offset(this.center);
      return point;
    }


    /*
     * Rectangles
     * ==========
     * 
     * Read-only.
     * X, Y, Size and Width values.
     */

    // The little black circle in the center of the clockface
    private Rectangle centerFace {
      get {
        return new Rectangle(
          (int)(this.center.X - this.centerFaceRadius),
          (int)(this.center.Y - this.centerFaceRadius),
          (int)(this.centerFaceRadius * 2),
          (int)(this.centerFaceRadius * 2)
        );
      }
    }

    // The large white circle
    private Rectangle innerFace {
      get {
        return new Rectangle(
          (int)(this.borderWidth + this.center.X - this.radius),
          (int)(this.borderWidth + this.center.Y - this.radius),
          (int)(this.diameter - (this.borderWidth * 2)),
          (int)(this.diameter - (this.borderWidth * 2))
        );
      }
    }

    // The outer black border
    private Rectangle outerFace {
      get {
        return new Rectangle(
          (int)(this.center.X - this.radius),
          (int)(this.center.Y - this.radius),
          (int)(this.diameter),
          (int)(this.diameter)
        );
      }
    }

    // An invisible box that the timezone text is printed in
    private Rectangle timeZonePosition {
      get {
        Point topLeft = this.position(8.5f / 12f, this.radius);
        Point topRight = this.position(3.5f / 12f, this.radius);
        return new Rectangle(
          topLeft.X, topLeft.Y,
          topRight.X - topLeft.X, this.textFontSize*3
        );
      }
    }
    
  }
}
