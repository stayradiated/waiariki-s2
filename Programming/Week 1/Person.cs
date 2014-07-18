using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person {
  class Program {
    static void Main(string[] args) {

      Steve steve = new Steve();

      Console.WriteLine("\n # Testing Steve\n");
      Test("Steve", steve.Name);
      Test(20, steve.Age);
      Test(63.00, steve.Weight);
      Test("Programming", steve.Interests[0]);
      Test("Web Development", steve.Interests[1]);
      Test("Speedsolving", steve.Interests[2]);
      Test("Doctor Who", steve.Interests[3]);
      Test("Rotorua, NZ", steve.Location);
      Test("Murphy the dog", steve.Pets[0]);
      Test("Tiger the cat", steve.Pets[1]);

      Jerry jerry = new Jerry();

      Console.WriteLine("\n # Testing Jerry\n");
      Test("Jerry", jerry.Name);
      Test(17, jerry.Age);
      Test(83.00, jerry.Weight);
      Test("Rugby", jerry.Interests[0]);
      Test("Swords", jerry.Interests[1]);
      Test("Emeralds", jerry.Interests[2]);
      Test("Auckland", jerry.Location);

      Console.Read();
    }

    static void Test(double expected, double actual) {
      if (expected != actual) { Console.Write(" x"); }
      else { Console.Write(" -"); }
      Console.WriteLine(" {0}", actual);
    }

    static void Test(int expected, int actual) {
      if (expected != actual) { Console.Write(" x"); }
      else{ Console.Write(" -"); }
      Console.WriteLine(" {0}", actual);
    }

    static void Test(object expected, object actual) {
      if (expected != actual) { Console.Write(" x"); }
      else { Console.Write(" -"); }
      Console.WriteLine(" {0}", actual);
    }

  }

  class Person {

    protected string name;
    protected int age;
    protected double weight;
    protected HashSet<string> interests;
    protected string location;

    public virtual string Name {
      get { return this.name; }
    }

    public virtual int Age {
      get { return this.age; }
    }

    public virtual double Weight {
      get { return this.weight; }
    }

    public virtual string[] Interests {
      get { return this.interests.ToArray(); }
    }

    public virtual string Location {
      get { return this.location; }
    }

  }

  class Steve : Person {

    private HashSet<string> pets;

    public Steve() {
      this.name = "Steve";
      this.age = 20;
      this.weight = 63.00;
      this.interests = new HashSet<string>(new string[] {
        "Programming",
        "Web Development",
        "Speedsolving",
        "Doctor Who"
      });
      this.location = "Rotorua";
      this.pets = new HashSet<string>(new string[] {
        "Murphy the dog",
        "Tiger the cat"
      });
    }

    public string[] Pets {
      get { return this.pets.ToArray(); }
    }

    public override string Location {
      get { return "Rotorua, NZ"; }
    }

  }

  class Jerry : Person {

    private string nickname;

    public Jerry() {
      this.name = "Jeremy";
      this.nickname = "Jerry";
      this.age = 17;
      this.weight = 83.00;
      this.interests = new HashSet<string>(new string[] {
        "Rugby",
        "Swords",
        "Emeralds"
      });
      this.location = "Auckland";
    }

    public override string Name {
      get { return this.nickname; }
    }

  }

}
