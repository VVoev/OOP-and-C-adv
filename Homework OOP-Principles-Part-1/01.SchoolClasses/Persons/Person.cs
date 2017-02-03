using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses.Persons
{
    public abstract class Person : IComparable<Person>
    {
        //fields
        protected string firstName;
        protected string lastName;
        protected string fullName;

        //properties
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                CheckForNull(value);
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                CheckForNull(value);
                this.lastName = value;
            }
        }

        public abstract string FullName { get; set; }

        private void CheckForNull(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("You must set a name");
            }
        }

        public int CompareTo(Person other)
        {
            return this.FullName.CompareTo(other.FullName);
        }
    }
}
