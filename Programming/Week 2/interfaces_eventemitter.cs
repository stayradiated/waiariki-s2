using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces {

  /*
   * EventListner Delegate
   * Callbacks must use this signature
   */

  public delegate void EventListener(object data);

  /*
   * IEventEmitter Interface
   * - Emit: trigger an event
   * - On: listen to an event
   * - Off: stop listening to an event
   */

  public interface IEventEmitter {
    void Emit(string name, object data);
    void On(string name, EventListener callback);
    void Off(string name, EventListener callback);
  }


  /*
   * EventEmitter Implementation
   * Uses a dictonary to store event names
   * Callbacks are stored in lists.
   */

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

      // subscribe to an event
      signals.On("event", Program.PrintText);

      // trigger an event
      signals.Emit("event", "This is sending some data to the thing");

      // unsubscribe to the event
      signals.Off("event", Program.PrintText);

      // trigger the event again
      signals.Emit("event", "You shouldn't see this");

      Console.Read();
    }

    public static void PrintText(object data) {
      Console.WriteLine((string)data);
    }
  }

}
