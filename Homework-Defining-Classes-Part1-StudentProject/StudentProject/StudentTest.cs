
namespace Homework_Defining_Classes_Part1_StudentProject.StudentProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class StudentTest
    {
        public static void TestStudents()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> studentsUASG = new List<Student>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                //5
                //Vladimir Ionkov Voev Programing Telerik 2
                //Maria Lubomirova Kumanova Marketing Unwe 3
                //Petar Petrov Ion PublicRe NBU 1
                //Qnko Madurov Barabon Finance SofiaUni 4
                //Martin Xaskuv Nufon Math Mandjata 1
                var input = Console.ReadLine().Split(' ').ToArray();
                string firstName = input[0];
                string surName = input[1];
                string lastName = input[2];
                string specialty = input[3];
                string university = input[4];
                int numer = int.Parse(input[5])-1;
                Course course = (Course)numer;
                Student currentStudent = new Student(firstName, surName, lastName, specialty, university, course);
                studentsUASG.Add(currentStudent);
            }
            var sortedStudents = studentsUASG.OrderBy(x => x.Course).ToList();
            Console.WriteLine("-----------------------------");
            Console.WriteLine(string.Join(Environment.NewLine, sortedStudents));
        }
    }
}
