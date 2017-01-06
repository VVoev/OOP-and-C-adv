using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MineOOPProjects.StudentProject.Personss;

namespace MineOOPProjects.StudentProject.Students
{
    class Student : Personss.Person
    {
        private int facultyNumber;
        private int semester;

        public int FacultyNumber
        {
            get { return this.facultyNumber; }
            set { this.facultyNumber = value; }
        }
        public int Semester
        {
            get { return this.semester; }
            set { this.semester = value; }
        }

        public Student(int age, string name,int facultyNumber) : base(age, name)
        {
            this.FacultyNumber = facultyNumber;
        }

        public Student(int age,string name,int facultyNumber,int semester):this(age,name,facultyNumber)
        {
            this.Semester = semester;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"I am a :{this.GetType().Name}");
            sb.AppendLine($"Name :    {this.Name}");
            sb.AppendLine($"Age :     {this.Age}");
            sb.AppendLine($"Faculty : {this.FacultyNumber}");
            return sb.ToString();
        }
        public override void Talk()
        {
            Console.WriteLine($"{this.GetType().Name} with name {this.Name } says : Hello how are you ;)");
        }
    }




    }

