using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Extension_Methods_Delegates_Lambda_LINQ.Linq_Extensions_Methods
{
    class StudentRepository
    {
        public IEnumerable<Student> GetAllStudents()
        {
            var oop = new Course { Id = 1, Name = "OOP" };
            var csharp = new Course { Id = 2, Name = "CSharp" };
            var javaScript = new Course { Id = 3, Name = "JavaScript" };
            var students = new List<Student>
            {
                new Student
                {
                    Id=1,
                    Name="Vlado",
                    Courses= new List<Course> {oop,javaScript }
                },
                new Student
                {
                    Id=2,
                    Name="Maria",
                    Courses = new List<Course> {oop,javaScript,csharp }
                },
                new Student
                {
                    Id=3,
                    Name="Spas",
                    Courses=new List<Course> {csharp,javaScript }
                },
            };
            return students;
        }
    }
}
