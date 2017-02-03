using SchoolClasses.Disciplines;
using SchoolClasses.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_OOP_Principles_Part_1.SchoolClasses.Persons
{
    public class Teacher : Person
    {

        //fields
        private IEnumerable<Discipline> disciplines;

        //properties

        public override string FullName
        {
            get
            {
                return string.Format($"{fullName}");
            }

            set
            {
                this.fullName = value;
            }
        }

        public IEnumerable<Discipline> Disciplines
        {
            get { return this.disciplines; }
            set { this.disciplines = value; }
        }

        //Constructor
        public Teacher(string name, IEnumerable<Discipline> disciplines)
        {
            this.FullName = name;
            this.Disciplines = disciplines;
        }

        //override
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.fullName);
            sb.AppendLine(string.Format($"Disciplines :{string.Join(Environment.NewLine, this.Disciplines)}"));
            return sb.ToString();
        }
    }
}
