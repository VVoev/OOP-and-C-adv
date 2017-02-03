using Homework_OOP_Principles_Part_1.SchoolClasses.Persons;
using SchoolClasses.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Principles_Part_1.SchoolClasses.Schools.SchoolClasses
{
    public class SchoolClass : IComparable<SchoolClass>
    {
        //fields
        private SchoolType type;
        private IEnumerable<Teacher> teachers;
        private IEnumerable<Student> students;

        //properties
        public SchoolType Type
        {
            get;
        }

        public IEnumerable<Teacher> Teachers
        {
            get { return this.teachers; }
            set { this.teachers = value; }
        }

        public IEnumerable<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        //Constructor
        public SchoolClass(SchoolType type, IEnumerable<Student> students, IEnumerable<Teacher> teachers)
        {
            this.Type = type;
            this.Students = students;
            this.Teachers = teachers;
        }

        public int CompareTo(SchoolClass other)
        {
            return this.Type.CompareTo(other.Type);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Type.ToString());
            sb.AppendLine(string.Format($"Teacher from class {this.Type.ToString()}"));
            sb.AppendLine(string.Join(Environment.NewLine, this.Teachers));
            sb.AppendLine(string.Format($"Students from class {this.Type.ToString()}"));
            sb.AppendLine(string.Join(Environment.NewLine, this.Students));
            return sb.ToString();
        }
    }
}
