using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals {
  class Program {

    public static HashSet<Create> Zoo = new HashSet<Create>();

    static void Main(string[] args) {
      Snake snake = new Snake();
      snake.Hiss();

      Mouse mouse = new Mouse();
      mouse.Squeak();

      Cartoon.Dog dog = new Cartoon.Dog();
      dog.Draw();
      dog.Bark();

      Cartoon.Cat cat = new Cartoon.Cat();
      cat.Draw();
      cat.Meow();

      mouse.Eat(cat);
      mouse.Eat(dog);
      snake.Eat(mouse);
      snake.Eat(cat);

      cat.Scratch(snake);
      snake.Slither();
      mouse.Hide();
      dog.Chase(cat);

      Console.WriteLine("\nThe following animals are in the Zoo:");
      foreach (Create creation in Zoo) {
        Console.WriteLine(" - {0}", creation.getName());
      }

      Console.Read();
    }
  }

  class Create {
    protected string name;

    public Create(string name) {
      this.name = name;
      Program.Zoo.Add(this);
    }

    public string getName() {
      return this.name;
    }

    protected void MakeSound(string sound) {
      Console.WriteLine("A {0} goes {1}", this.name, sound);
    }

  }

  class Animal : Create {

    public Animal(string name)
      : base(name) {
    }
    public virtual void Eat(Create creation) {
      // eat anything
      Console.WriteLine("A {0} has eaten a {1}", this.name, creation.getName());
    }
  }

  class Snake : Animal {
    public Snake()
      : base("Snake") {
    }

    public void Hiss() {
      this.MakeSound("hissss");
    }

    public void Slither() {
      Console.WriteLine("A snake has slithered away");
    }

    public override void Eat(Create creation) {
      if (creation is Cartoon.Cartoon) {
        Console.WriteLine("A Snake could not eat a cartoon {0}", creation.getName());
        return;
      } else {
        base.Eat(creation);
      }
    }
  }

  class Mouse : Animal {
    public Mouse()
      : base("Mouse") {
    }

    public void Squeak() {
      this.MakeSound("squeak!");
    }

    public void Hide() {
      Console.WriteLine("A mouse has hidden");
    }
  }


  namespace Cartoon {

    class Cartoon : Create {
      public Cartoon(string name)
        : base(name) {
      }

      public void Draw() {
        Console.WriteLine("A {0} has been drawn", this.name);
      }
    }

    class Dog : Cartoon {
      public Dog()
        : base("Dog") {
      }

      public void Bark() {
        this.MakeSound("bark!");
      }

      public void Chase(Cat cat) {
        Console.WriteLine("A dog is chasing a cat!");
      }
    }

    class Cat : Cartoon {
      public Cat()
        : base("Cat") {
      }

      public void Meow() {
        this.MakeSound("meow!");
      }

      public void Scratch(Create creation) {
        Console.WriteLine("A cat has scratched a {0}", creation.getName());
      }
    }

  }

}
