using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MineExam.StudentProject.University
{
    class Professor : Person,IEnumerable
    {
        private List<Student> students;
        public List<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }
        public Professor(string firstName, string lastName, int age, long ID) : base(firstName, lastName, age, ID)
        {
            this.Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
