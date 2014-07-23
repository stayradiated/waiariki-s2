public abstract class Person {

  protected string name;
  public abstract decimal PayExpenses();

  public virtual int GetSleepAmount () {
    return 8; // default implementation
  };

  public abstract string Name {
    get;
    set;
  };

}

public class Student : Person {

  public override decimal PayExpenses () {
    // custom implementation
  };

  public abstract string Name {
    get { return this.name; }
    set { this.name = value; }
  }

};
