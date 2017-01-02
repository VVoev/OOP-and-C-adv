using StudentAndWorkers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndWorkers.People
{
    public class Student : Human
    {
        //fields
        private decimal grade;

        //properties
        public decimal Grade { get { return this.grade; }set { this.grade = value; } }

        //Constructor
        public Student(string firstname, string lastName,decimal grade)
            : base(firstname, lastName)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return string.Format($"{this.FullName} Grades: {this.Grade}");
        }
    }
}
