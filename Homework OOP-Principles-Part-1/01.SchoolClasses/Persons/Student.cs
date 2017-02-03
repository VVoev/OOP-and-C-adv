using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses.Persons
{
    public class Student : Person
    {
        //fields
        private int numberInClass;

        //properties
        public override string FullName
        {
            get
            {
                return this.fullName;
            }

            set
            {
                this.fullName = value;
            }
        }

        public int NumberInClass
        {
            get { return this.numberInClass; }
            set
            {
                CheckForZero(value);
                this.numberInClass = value;
            }
        }

        //Constructor
        public Student(string name,int number)
        {
            fullName = name;
            this.NumberInClass = number;
        }

        //override
        public override string ToString()
        {
            return string.Format($"{this.FullName} Number in class {this.NumberInClass}");
        }

        private void CheckForZero(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Personal student number should be a positive number");
            }
        }
    }
}
