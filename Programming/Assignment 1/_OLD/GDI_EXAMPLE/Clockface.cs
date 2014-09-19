using System;
using System.Drawing;
using System.Threading;

namespace GDI_EXAMPLE {

  class Clockface {

    private Point location;
    private float diameter;
    private float minutes;
    private float hours;
    private float seconds;
    private Timer timer;

    public Clockface() {
      this.location = new Point(20, 10);
      this.diameter = 250;

      this.timer = new Timer(new TimerCallback(this.tick), null, 0, 16);
    }

    private float radius {
      get { return this.diameter / 2f; }
    }

    private float borderWidth {
      get { return this.diameter / 50f; }
    }

    private float hourHandRadius {
      get { return this.radius / 2f; }
    }

    private float minuteHandRadius {
      get { return this.radius / 1.2f; }
    }

    private float secondHandRadius {
      get { return this.radius / 1.2f; }
    }

    private float centerFaceRadius {
      get { return this.radius / 10; }
    }

    private Point center {
      get {
        return new Point(
          (int)(this.location.X + this.radius),
          (int)(this.location.Y + this.radius)
        );
      }
    }

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

    private Rectangle innerFace {
      get {
        return new Rectangle(
          (int)(this.location.X + this.borderWidth),
          (int)(this.location.Y + this.borderWidth),
          (int)(this.diameter - (this.borderWidth * 2)),
          (int)(this.diameter - (this.borderWidth * 2))
        );
      }
    }

    private Rectangle outerFace {
      get {
        return new Rectangle(
          (int)(this.location.X),
          (int)(this.location.Y),
          (int)(this.diameter),
          (int)(this.diameter)
        );
      }
    }

    private Point secondHand {
      get {
        return this.hand(this.seconds, this.secondHandRadius);
      }
    }

    private Point minuteHand {
      get {
        return this.hand(this.minutes, this.minuteHandRadius);
      }
    }

    private Point hourHand {
      get {
        return this.hand(this.hours, this.hourHandRadius);
      }
    }

    private Point hand (float degrees, float radius) {
      return new Point(
        (int)(this.center.X + radius * Math.Cos(degrees * 2 * Math.PI - (Math.PI / 2))),
        (int)(this.center.Y + radius * Math.Sin(degrees * 2 * Math.PI - (Math.PI / 2)))
      );
    }

    private void tick(Object source) {
      this.seconds = (DateTime.Now.Second / 60f) + (DateTime.Now.Millisecond / 60000f);
      this.minutes = (DateTime.Now.Minute / 60f) + (this.seconds / 60f);
      this.hours = (DateTime.Now.Hour / 12f) + (this.minutes / 12f);
      Console.WriteLine(DateTime.Now.Millisecond);
      Console.WriteLine("Seconds:" +  this.seconds);
      Console.WriteLine("Minutes:" + this.minutes);
      Console.WriteLine("Hours:" + this.hours);
    }

    public void Draw(Graphics graphics) {
      Brush background = new SolidBrush(Color.Black);
      Brush foreground = new SolidBrush(Color.White);

      graphics.FillEllipse(background, this.outerFace);
      graphics.FillEllipse(foreground, this.innerFace);
      graphics.FillEllipse(background, this.centerFace);

      graphics.DrawLine(new Pen(background, 1), this.center, this.secondHand);
      graphics.DrawLine(new Pen(background, 2), this.center, this.minuteHand);
      graphics.DrawLine(new Pen(background, 6), this.center, this.hourHand);
    }

  }
}
