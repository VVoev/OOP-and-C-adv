using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dgroup;
using System.Threading.Tasks;

namespace StudentSystem
{
    public class Student 
    {
        private string firstName;
        private string lastName;
        private int age;
        private string fn;
        private string tel;
        private string email;
        private List<double> marks;
        private Group groupNumber;




        public string FirstName
        {
            get { return firstName; }
            private set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 2)
                    throw new ArgumentNullException("The name must not be empty and at least 2 characters long");

                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 2)
                    throw new ArgumentNullException("The name must not be empty and at least 2 characters long");

                lastName = value;
            }
        }

        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 0 || value > 130)
                    throw new ArgumentOutOfRangeException("The age of the student must be between 0 years and 130 years");

                age = value;
            }
        }

        public string Fn
        {
            get { return fn; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The faculty number of the student cannot be empty");

                fn = value;
            }
        }

        public string Tel
        {
            get { return tel; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The telephone must contain only digits and optional + sign");

                tel = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                this.email = value;

            }
        }
        

        public List<double> Marks
        {
            get { return marks; }
            private set
            {
                if (value.Any(mark => mark < 2 || mark > 6))
                {
                    throw new ArgumentOutOfRangeException("The mark should be between 2 and 6");
                }
                marks = value;
            }
        }

        public Group GroupNumber
        {
            get { return groupNumber; }
            private set
            {
                this.groupNumber = value;
            }
        }





        public Student(string firstName,string lastName,int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Student(string firstName, string lastName, string fn, string tel, string email, List<double> marks,
            Group groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Fn = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;

        }

        public override string ToString()
        {
            if(CheckForNull(Email, Tel))
            {
                return string.Format("{0} {1} Age:{2}", this.FirstName, this.LastName, this.Age);
            }
            else
            {
                return String.Format("{0} {1}, FN:{2}, Tel:{3}, Email:{4}, Marks:({5}), [Group:{6}] [Number of Departament:{7}]",
                this.FirstName, this.LastName, this.Fn, this.Tel, this.Email, String.Join(" ", this.Marks), this.GroupNumber.DepartmentName,this.GroupNumber.GroupNumbers);
            }
                
        }

        private bool CheckForNull(string email, string tel)
        {
            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(tel))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string PrintMarks()
        {
            return "(" + String.Join(", ", this.Marks) + ")";
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }


}