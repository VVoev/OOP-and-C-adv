using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Common_Type_System.System.Object_Overloading
{
    class Student
    {
        private string firstName;
        private int age;

        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }

        public Student()
        {            
        }


        public override string ToString()
        {
            return String.Format(
                "Student(Name: {0}, Age: {1})",
                this.FirstName ?? "<unnamed>", this.Age);
        }

        public override bool Equals(object param)
        {
            // If the cast is invalid, the result will be null
            Student student = param as Student;

            // Check if we have valid not null Student object
            if (student == null)
            {
                return false;
            }

            // Compare the reference type member fields Name
            if (!object.Equals(this.FirstName, this.FirstName))
            {
                return false;
            }

            // Compare the value type member fields
            if (!object.Equals(this.Age, this.Age))
            {
                return false;
            }
            return true;
        }

        public override int  GetHashCode()
        {
            return FirstName.GetHashCode() ^ Age.GetHashCode();
        }

        public static bool operator ==(Student first,Student second)
        {
            return Student.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !Student.Equals(first, second);
        }

    }
}
