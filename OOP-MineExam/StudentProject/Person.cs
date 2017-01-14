using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MineExam.StudentProject
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public long ID { get; set; }
        public string Fullname
        {
            get { return this.FirstName +" "+ this.Lastname; }
            protected set { }
        }


        public Person(string firstName, string lastName, int age, long ID)
        {
            this.FirstName = firstName;
            this.Lastname = lastName;
            this.Age = age;
            this.ID = ID;
        }
    }
}
