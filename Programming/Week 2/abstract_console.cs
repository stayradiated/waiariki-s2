using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Write a console application that has:
 * - An abstract class MyAbstractClass with only two methods:
 * - A non-abstract method that subtracts two numbers
 * - An abstract method for dividing two numbers
 * - Another class MyDerivedClass that:
 *   - Implements the abstract method from its base class, and
 *   - Has a Main() method which:
 *   - Calls the non-abstract method to calculate the difference between two numbers
 *   - Calls the implemented abstract method to calculate result of dividing two numbers
 *   - Displays the calculated results
 */ 

namespace AbstractApp {

  public abstract class MyAbstractClass {

    public double Subtract (double a, double b) {
      return a - b;
    }

    public abstract double Divide (double a, double b);

  }

  public class MyDerivedClass : MyAbstractClass {

    public override double Divide (double a, double b) {
      return a / b ;
    }

    public static void Main (string[] args) {
      MyDerivedClass calc = new MyDerivedClass();

      Console.Write("200 - 100: ");
      Console.WriteLine(calc.Subtract(200, 100));

      Console.Write("300 / 200: ");
      Console.WriteLine(calc.Divide(300, 200));

      Console.Read();
    }

  }

}
