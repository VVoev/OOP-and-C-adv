using OOP_MineExam.CustomSettings;
using OOP_MineExam.StudentProject.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MineExam.StudentProject
{
    class Test
    {
        public static void Go()
        {
            Custom.ProgramStart("University");
            Custom.MakeFreeLines(2);

            //Add five Students
            var studentVlado = new Student("Vlado", "Voev", 31, 848383404, 28244);
            var studentMimi = new Student("Mimi", "Kumanova", 22, 443232, 131313);
            var studentSpas = new Student("Spas", "Uzunov", 28, 666999888, 38376);
            var studentMitko = new Student("Mitko", "Kirilov", 25, 4346373, 15578);
            var studentKristina = new Student("Kristina", "Alexandrova", 30, 4455667788, 44225);
            var allStudents = new List<Student>();

            //Add professor
            var profesorJK = new Professor("Ivailo", "Stratiev", 65, 255578);
          
            //add Students in a group
            allStudents.Add(studentMimi);
            allStudents.Add(studentSpas);
            allStudents.Add(studentVlado);
            allStudents.Add(studentKristina);
            allStudents.Add(studentMitko);

            //assing all students to a profesor
            profesorJK.AddStudent(studentMimi);
            profesorJK.AddStudent(studentSpas);
            profesorJK.AddStudent(studentVlado);
            profesorJK.AddStudent(studentKristina);
            profesorJK.AddStudent(studentMitko);

            //Add some marks on a different Discipline
            foreach (var student in allStudents)
            {
                System.Threading.Thread.Sleep(100);
                student.Marks.Add("IT",(long)Custom.RandomNumber2to6());
                System.Threading.Thread.Sleep(100);
                student.Marks.Add("Marketing", (long)Custom.RandomNumber2to6());
                System.Threading.Thread.Sleep(300);
                student.Marks.Add("Algorithms", (long)Custom.RandomNumber2to6());
            }

            var studentsSuccesfullyGraduate = profesorJK.Students.Where(x => x.Marks["IT"] > 4L);
            foreach (var student in studentsSuccesfullyGraduate)
            {
                Console.WriteLine("I pass the course"+student);
            }

            foreach (var stud in allStudents)
            {
                Console.Write(stud);
                foreach (var item in stud.Marks)
                {
                    Console.Write($"[{item.Key}:{item.Value}]");
                }
                Custom.MakeFreeLines(2);
            }

            //Sorted students by IT exam (if exam are equal than they are sorted by algorithm course)

            Custom.ProgramStart("Students with IT Exam passed with more than 4");
            var sortStudents = allStudents.OrderBy(x => x.Marks["IT"]).ThenBy(x => x.Marks["Algorithms"]);
            foreach (var sort in sortStudents)
            {
                Console.Write(sort);
                foreach (var item in sort.Marks)
                {
                    Console.Write($"[{item.Key}:{item.Value}]");
                }
                Custom.MakeFreeLines(2);
            }
            Custom.ProgramEnd("University");
            Custom.MakeFreeLines(2);
            Custom.End();
        }
    }
}
