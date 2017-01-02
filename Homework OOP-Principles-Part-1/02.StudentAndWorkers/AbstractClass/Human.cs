using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndWorkers.AbstractClass
{
    public abstract class Human : IComparable<Human>
    {
        //fields
        private string firstName;
        private string lastName;

        //properties
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string FullName
        {
            get { return this.firstName + " " + this.lastName; }
        }

        //constructor
        public Human(string firstname,string lastName)
        {
            this.FirstName = firstname;
            this.LastName = lastName;
        }

        public int CompareTo(Human other)
        {
            if (this.FirstName.CompareTo(other.FirstName) == 0)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            return this.FirstName.CompareTo(other.FirstName);
        }
    }
}
