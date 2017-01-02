using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Defining_Classes_Part1_StudentProject.StudentProject
{
    public class Student
    {
        //Fields in class Student
        private Course course;
        private string firstName;
        private string surName;
        private string lastName;
        private string specialty;
        private string university;

        //Properties in class Student
        public Course Course
        {
            get { return this.course; }
            set { this.course = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string SurName
        {
            get { return this.surName; }
            set { this.surName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string Specialty
        {
            get { return this.specialty; }
            set { this.specialty = value; }
        }
        public string University
        {
            get { return this.university; }
            set { this.university = value; }
        }

        //Constructor in class Student
        public Student(string firstName, string surName, string lastName, string specialty, string university, Course course)
        {
            this.FirstName = firstName;
            this.SurName = surName;
            this.LastName = lastName;
            this.Specialty = specialty;
            this.University = university;
            this.Course = course;
        }

        //Methods in class Student
        public string PersonalStudentInfo(string name,string surname,string lastname,string university)
        {
            var sb = new StringBuilder();
            sb.AppendLine(name);
            sb.AppendLine(surname);
            sb.AppendLine(lastname);
            sb.AppendLine(university);
            return sb.ToString();
        }

        public override string ToString()
        {
            var studentInfo = new StringBuilder();
            if (this.FirstName != null)
            {
                studentInfo.AppendLine("Firstname : " + this.FirstName);
            }
            if (this.SurName != null)
            {
                studentInfo.AppendLine("SurName : " + this.SurName);
            }
            if (this.LastName != null)
            {
                studentInfo.AppendLine("LastName : " + this.LastName);
            }
            if (this.University != null)
            {
                studentInfo.AppendLine("University : " + this.University);

            }
            if (this.Course != 0)
            {
                studentInfo.AppendLine("Course : " + this.Course);

            }
            return studentInfo.ToString();
        }
    }
}
