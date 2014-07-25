using System;
using System.Collections.Generic;
using System.Text;
using PersonNamespace;

namespace StudentNamespace
{
    public class Student : Person, ITravelerNamespace.ITraveler
    {
        private string major;
        private string studentId;

        public Student()
            : base()   // We do not need to explicitely put ':base()'. If we omit it, it will be there by default.
        {
            major = "unknown";
            studentId = "";
        }

        //--------Constructor that sends arguments to the base class.-------

        public Student(string id, string lName, string fName, string maj, string sId)
            : base(id, lName, fName)
        {
            major = maj;
            studentId = sId;
        }

        //-------Read-only property for studentId-----------

        public string StudentId
        {
            get
            {
                return studentId;
            }
        }

        //-------Property for major data attribute.--------

        public string Major
        {
            get
            {
                return major;
            }
            set
            {
                major = value;
            }
        }

        //------Overrides GetSleepAmount() method of the Person class.--------

        public override int GetSleepAmount()  // GetSleepAmount() method in the base Person class is defined
        // as virtual.
        {
            return 6;
        }

        //---Using the 'base' keyword we call the overridden GetSleepAmount() method of the Person class.--

        public int CallOverriddenGetSleepAmount()
        {
            return base.GetSleepAmount();
        }

        public string GetDestination() {
          return "School";
        }

        public string GetStartLocation() {
          return "Home";
        }

        public double DetermineMiles() {
          return 100;
        }
    }
}