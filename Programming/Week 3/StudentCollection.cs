using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/*
Modify the above application to create a StudentRecords collection class in
which you create an array of student objects, Put the code for load and save
records into the collection class, creating any additional code that will cycle
through the student objects, extract the object data and write it to a file.
Create a form that will allow you to add and display the student data from each
student object in turn. (Use a fixed number of objects in the student array so
as not to make array management too difficult). Create an overloaded
constructor for the collection class that will read data from the data file and
populate the student objects.
*/


namespace StudentCollection {

  class Program {
    static void Main(string[] args) {
      Student student = new Student("George Czabania", 20);
      StudentRecords records = new StudentRecords();

      records.Load();
      Console.WriteLine("Loaded {0} student(s)", records.Count);

      records.Add(student);
      records.Save();

      Console.Read();
    }
  }

  class Student {

    private string name;
    private int age;

    public Student() {
      this.name = "";
      this.age = 0;
    }

    public Student(string name, int age) {
      this.name = name;
      this.age = age;
    }

    public void Parse(string line) {
      string[] sections = line.Split(',');
      this.name = sections[0];
      this.age = Int32.Parse(sections[1]);
    }

    public override string ToString() {
      return string.Format("{0},{1}",
        this.name, this.age);
    }

  }

  class StudentRecords : List<Student> {

    readonly string PATH;

    public StudentRecords() {
      this.PATH = "records.txt";
    }

    public void Load() {
      try {
        StreamReader sr = new StreamReader(this.PATH);
        while (sr.Peek() > -1) {
          string line = sr.ReadLine(); ;
          Student student = new Student();
          student.Parse(line);
          this.Add(student);
        }
        sr.Close();
      } catch {
        Console.WriteLine("Could not read file: {0}", this.PATH);
      }
    }

    public void Save() {
      StreamWriter sw = new StreamWriter(this.PATH);

      foreach (Student student in this) {
        sw.WriteLine(student.ToString());
      }

      sw.Close();
    }

  }

}
