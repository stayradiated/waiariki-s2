using System;

namespace Generics {

  class Program {
    public static void Main(string[] args) {
      Map<string, string> map = new Map<string, string>();
      map["a"] = "Hello";
      map["b"] = "World";
      map["c"] = "This is pretty awesome";
      Console.WriteLine(map["a"]);
      Console.WriteLine(map["b"]);
      Console.WriteLine(map["c"]);

      map["a"] = "overwritten";
      Console.WriteLine(map["a"]);
    }
  }

}
