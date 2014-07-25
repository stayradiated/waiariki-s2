using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {

  public delegate void EventListener(object data);

  public interface IEventEmitter {

    void Emit(string name, object data);

    void On(string name, EventListener callback);

    void Off(string name, EventListener callback);

  }

  public class Signals : IEventEmitter {

    private Dictionary<string, List<EventListener>> Events;

    public Signals() {
      this.Events = new Dictionary<string, List<EventListener>>();
    }

    public void Emit(string name, object data) {
      if (this.Events.ContainsKey(name)) {
        List<EventListener> callbacks = this.Events[name];
        foreach (EventListener callback in callbacks) {
          callback(data);
        }
      }
    }

    public void On(string name, EventListener callback) {
      if (!this.Events.ContainsKey(name)) {
        this.Events[name] = new List<EventListener>();
      }
      this.Events[name].Add(callback);
    }

    public void Off(string name, EventListener callback) {
      if (this.Events.ContainsKey(name)) {
        this.Events[name].Remove(callback);
      }
    }

  }

  public class Program {
    public static void Main(string[] args) {
      Signals signals = new Signals();

      signals.On("event", Program.PrintText);

      signals.Emit("event", "This is sending some data to the thing");

      signals.Off("event", Program.PrintText);

      signals.Emit("event", "This is some more data");

      Console.Read();
    }

    public static void PrintText(object data) {
      Console.WriteLine((string)data);
    }
  }

}
