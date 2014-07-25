using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentTravel {
  public partial class Form1 : Form {

    private StudentNamespace.Student student;

    public Form1() {
      InitializeComponent();
      this.student = new StudentNamespace.Student(
        "1", "Li", "Anna", "major", "1"
      );
      student.Age = 25;
    }

    private void button1_Click(object sender, EventArgs e) {
      txtName.Text = this.student.FirstName + ' ' + this.student.LastName;
      txtAge.Text = this.student.Age.ToString();
      txtId.Text = this.student.StudentId;
      txtStudentSleep.Text = this.student.GetSleepAmount().ToString();
      txtAdultSleep.Text = this.student.CallOverriddenGetSleepAmount().ToString();
    }

    private void button2_Click(object sender, EventArgs e) {
      txtTravFrom.Text = this.student.GetStartLocation();
      txtTravTo.Text = this.student.GetDestination();
      txtTravMiles.Text = this.student.DetermineMiles().ToString();
    }
  }
}
