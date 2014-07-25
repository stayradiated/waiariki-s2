using System;
using System.Collections.Generic;
using System.Text;

namespace PersonNamespace
{
    public class Person
    {
        private string idNumber;
        private string lastName;
        private string firstName;
        private int age;

        public Person()   // Constructor with zero arguments.
        {
            idNumber = " ";
            lastName = "unknown";
            firstName = "unknown";
            age = 0;
        }

        public Person(string id, string lName, string fName, int anAge)   // Constructor with four arguments.
        {
            idNumber = id;
            lastName = lName;
            firstName = fName;
            age = anAge;
        }

        public Person(string id, string lName, string fName)   // Constructor with three arguments.
        {
            idNumber = id;
            lastName = lName;
            firstName = fName;
            age = 0;
        }

        public Person(string id)   // Constructor with one argument.
        {
            idNumber = id;
            lastName = "unknown";
            firstName = "unknown";
            age = 0;
        }

        //---------------Read-only property.  ID number can not be changed.------------------

        public string IdNumber
        {
            get
            {
                return idNumber;
            }
        }

        //---------------Property for last name.----------------------

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        //----------------Read-only property.  First name can not be changed.-----------

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        //-------------Property for age.-----------------------

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        //--------------Overrides ToString() method from the Object class.-------------------

        public override string ToString()  //Possible to do,because ToString() in the Object class is defined 
                                           //  as virtual.
        {
            return firstName + " " + lastName;
        }

        // ----------Virtual method can be overriden by subclasses of the Person class.-------

        public virtual int GetSleepAmount()   //Plan to override it with the one in the Student subclass.
        {
            return 8;
        }

    }
}