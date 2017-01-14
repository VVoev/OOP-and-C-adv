using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MineExam.StudentProject.University
{
    class Student : Person
    {
        public List<Student> StudentList;
        public long FacultyNumber { get; set; }
        public Dictionary<string, long> Marks;
        public Student(string firstName, string lastName, int age, long ID,long facultyNumber,Dictionary<string, long>marks)
            : base(firstName, lastName, age, ID)
        {
            this.FacultyNumber = facultyNumber;
            this.Marks = marks;
        }
        public Student(string firstName,string lastName)
            :this(firstName,lastName,20,48855)
        {
        
        }
        public Student(string firstName,string lastName,int age,long id,long facultyNumber)
            :this(firstName,lastName,age,id)
        {
            this.FacultyNumber = facultyNumber;
            this.Marks = new Dictionary<string, long>();
            this.StudentList = new List<Student>();
        }


        public Student(string firstName,string lastName,int age,long id)
            :base(firstName,lastName,age,id)
        {

        }



        public override string ToString()
        {
            return string.Format($@"Student name:{this.Fullname}{Environment.NewLine}Age:{this.Age}{Environment.NewLine}Id:{this.ID}{Environment.NewLine}Faculty Number:{this.FacultyNumber}{Environment.NewLine}Exams marks: ");

	
        }
    }
}
