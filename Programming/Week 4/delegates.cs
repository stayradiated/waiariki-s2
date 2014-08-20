using System;

namespace DelegateExample {

  delegate void GreetPerson (Person person);

  class Program {

    static void Main () {
      Room room = new Room();

      Person jack = new Person("Jack", "G'day {0}");
      Person jill = new Person("Jill", "Hello {0}");
      Person ben = new Person("Ben", "Hi {0}");

      room.AddPerson(jack);
      room.AddPerson(jill);
      room.AddPerson(ben);
    }

  }

  class Person {
    public string name;
    public string greeting;

    public Person (string name, string greeting) {
      this.name = name;
      this.greeting = greeting;
    }

    public void Greet (Person person) {
      string message = string.Format(greeting, person.name);
      Console.WriteLine("{0}: {1}", this.name, message);
    }
  }

  class Room {

    private GreetPerson Greet;

    public void AddPerson (Person person) {
      Console.WriteLine("## {0} has entered the room", person.name);
      if (this.Greet != null) this.Greet(person);
      this.Greet += person.Greet;
    }

  }

}

