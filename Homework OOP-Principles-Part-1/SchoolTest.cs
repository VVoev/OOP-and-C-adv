using Homework_OOP_Principles_Part_1.SchoolClasses.Persons;
using Homework_OOP_Principles_Part_1.SchoolClasses.Schools;
using Homework_OOP_Principles_Part_1.SchoolClasses.Schools.SchoolClasses;
using SchoolClasses.Disciplines;
using SchoolClasses.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Principles_Part_1.SchoolClasses
{
    class SchoolTest
    {
        public static void Go()
        {
            //add students
            Student student1 = new Student("Petar Jekov",1);
            Student student2 = new Student("Poli Ganeva",5);
            Student student3 = new Student("Iliqn Xristov",3);
            Student student4 = new Student("Mario Marinov",2);
            Student student5 = new Student("Iordan Dimitrov",6);
            Student student6 = new Student("Petya Todorova", 19);
            var students = new SortedSet<Student>() { student1, student2, student3,student4,student5,student6 };



            //add disciplines
            Discipline math = new Discipline(DisciplineType.Math, 10, 3);
            Discipline cSharp = new Discipline(DisciplineType.CSharp, 20, 2);
            Discipline javaScript = new Discipline(DisciplineType.JavaScript, 30, 4);
            Discipline spanish = new Discipline(DisciplineType.Spanish, 40, 10);
            Discipline psysics = new Discipline(DisciplineType.Physics, 12, 6);

            //add teachers
            Teacher teacher1 = new Teacher("Atanas Mladenov", new List<Discipline> { math, spanish, psysics });
            Teacher teacher2 = new Teacher("Konstantin Parapanov", new List<Discipline> { math, cSharp, javaScript });
            Teacher teacher3 = new Teacher("Mariela Filipova", new List<Discipline> { psysics, spanish });
            var teachers = new SortedSet<Teacher>() { teacher1, teacher2, teacher3 };

            //add class to school
            var firstClass = new SchoolClass(SchoolType.A, new List<Student> { student1, student2 }, new List<Teacher> { teacher2 });
            var secondClass = new SchoolClass(SchoolType.B, students, teachers);
            var thirdClass = new SchoolClass(SchoolType.C, students, teachers);
            var classes = new SortedSet<SchoolClass>() { firstClass, secondClass, thirdClass };

            //add School
            var daskalo = new School(classes);
            Console.WriteLine(daskalo);







        }
    }
}
