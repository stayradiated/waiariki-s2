using System;
using System.Text;
using System.Xml;

namespace Parser {

  class Program {

    public static void Main (string[] args) {
      XmlDocument doc = new XmlDocument();
      doc.Load("company.xml");

      XmlNode employees = doc.DocumentElement.SelectSingleNode("/company/employees");
      XmlNode departments = doc.DocumentElement.SelectSingleNode("/company/departments");

      Console.WriteLine("# Employees\n");

      foreach(XmlNode employee in employees.ChildNodes) {

        string depId = employee.SelectSingleNode("department").InnerText;
        string xpath = string.Format("descendant::department[id=\"{0}\"]", depId);
        XmlNode department = departments.SelectSingleNode(xpath);

        Console.WriteLine("Name: {0}\nPhone: {1}\nDepartment: {2}\n",
          employee.SelectSingleNode("name").InnerText,
          employee.SelectSingleNode("phone").InnerText,
          department.SelectSingleNode("name").InnerText
        );
      }

    }
  }
}
