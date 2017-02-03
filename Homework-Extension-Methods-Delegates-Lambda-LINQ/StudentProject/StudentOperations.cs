using OOP_MineExam.CustomSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExtensionForStudentsss;
using StudentSystem;
using Dgroup;

namespace StudentOp
{
    public class StudentOperations
    {
        public static void Go()
        {
            var watch = Custom.StartProgram();
            Custom.ProgramStart("Student Operations");

            var studentList = new List<Student>();
            var firstStudent = new Student("Petar", "Qnkov", 22);
            var secondStudent = new Student("Georgi", "Minkov", 40);
            var thirdStudent = new Student("Spas", "Barekov", 22);
            var fourthStudent = new Student("Qnko", "Veselinov", 44);
            var fifthStudent = new Student("Dilqn", "Anov", 18);

            studentList.Add(firstStudent);
            studentList.Add(secondStudent);
            studentList.Add(thirdStudent);
            studentList.Add(fourthStudent);
            studentList.Add(fifthStudent);

            var firstBeforeLast = studentList.Where(x => x.FirstName.CompareTo(x.LastName) < 0).ToList();
            Console.WriteLine("Problem 3 Solved--Sorted by First and last name: \r\n"+string.Join(Environment.NewLine,firstBeforeLast));

            Custom.MakeFreeLines(3);

            var studentsBetween18and24 = studentList.Where(x => x.Age >= 18 && x.Age <= 24).OrderBy(x => x.Age);
            Console.WriteLine("Problem 4 Solved--Sorted by age 18-24: \r\n" + string.Join(Environment.NewLine, studentsBetween18and24));

            Custom.MakeFreeLines(3);

            var studentsOrderedWithLambda = studentList.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            Console.WriteLine("Problem 5 Solved--Sorted by Lambda Expressions: \r\n" + string.Join(Environment.NewLine, studentsOrderedWithLambda));

            Custom.ProgramEnd("Student Operations");
            Custom.End(watch);
        }
        public static void LinqStudents()
        {
            var watch = Custom.StartProgram();
            Custom.ProgramStart("Students from group 2");
            var listStudentsTelerik = new List<Student>();
            Student wordtStudent, goodStudent, topStudent, averageStudent, skatavkaStudent;
            CreateStudent(out wordtStudent, out goodStudent, out topStudent, out averageStudent, out skatavkaStudent);
            listStudentsTelerik.Add(wordtStudent);
            listStudentsTelerik.Add(topStudent);
            listStudentsTelerik.Add(goodStudent);
            listStudentsTelerik.Add(averageStudent);
            listStudentsTelerik.Add(skatavkaStudent);
            Custom.MakeFreeLines(2);
            //Students from group 2

            int groupTwo = 2;
            var studentsFromGroupTwo = listStudentsTelerik.Where(x => x.GroupNumber.GroupNumbers == groupTwo).OrderBy(x => x.FirstName);
            Console.WriteLine(string.Join(Environment.NewLine,studentsFromGroupTwo));
            Custom.MakeFreeLines(2);


            Custom.ProgramEnd("Students from group 2");
            Custom.End(watch);

            //Students from group 2 with extensions
            watch = Custom.StartProgram();
            Custom.ProgramStart("Students from group 2 solved with extensions");

            var studentsByGroup = listStudentsTelerik.OrderByGroup(groupTwo)
                                  .ThenByFirstName().ToList();
            Console.WriteLine(string.Join(Environment.NewLine,studentsByGroup));

            Custom.MakeFreeLines(1);
            Custom.ProgramEnd("Students from group 2 solved with extensions");
            Custom.End(watch);

            //Students with abv.bg
            Custom.ProgramStart("Students with email containing @abv.bg");
            var email = "@abv.bg";
            var studentsWithAbv = listStudentsTelerik.Where(x => x.Email.Contains(email));
            var studentsWithExtensions = listStudentsTelerik.ExtractByEmail(email).OrderBy(x => x.GroupNumber.GroupNumbers);
            Console.WriteLine(string.Join(Environment.NewLine, studentsWithAbv));
            Custom.MakeFreeLines(2);
            foreach (var item in studentsWithExtensions)
            {
                Console.WriteLine(item);
            }
            Custom.MakeFreeLines(1);
            Custom.ProgramEnd("Students with email containing @abv.bg");
            Custom.End(watch);

            //Students by Phone
            Custom.ProgramStart("Students by Phone");
            var sofia = "0883";
            var studentsFromSofia = listStudentsTelerik.Where(x => x.Tel.StartsWith(sofia));
            var studentsFromSofiaExTensions = listStudentsTelerik.FromTown(sofia);
            Console.WriteLine(string.Join(Environment.NewLine, studentsFromSofia));

            Console.WriteLine(string.Join(Environment.NewLine, studentsFromSofiaExTensions));

            Custom.ProgramEnd("Students by Phone");
            Custom.End(watch);

            //Students by Marks
            Custom.ProgramStart("Students by Marks");
            double mark = 6;
            var studentsWithMArk6 = listStudentsTelerik
                                    .Where(x => x.Marks.Contains(mark))
                                    .Select(x => new
                                    {
                                        Fullname = x.FirstName + " " + x.LastName,
                                        Marks = x.Marks
                                    }).ToList();
            foreach (var student in studentsWithMArk6)
            {
                Console.Write(student.Fullname);
                Console.WriteLine(string.Join(" ",student.Marks));
            }



            Custom.ProgramEnd("Students by Marks");
            Custom.End(watch);

            //Students with two marks
            Custom.ProgramStart("Students with Two Marks");

            var studentsWith2Marks = listStudentsTelerik.Where(x => x.Marks.Count == 2);
            var studentsWithTwoMarksExtenstions = listStudentsTelerik.ByMarkLenght(2);
            Console.WriteLine(string.Join(Environment.NewLine, studentsWith2Marks));
            Console.WriteLine(string.Join(Environment.NewLine, studentsWithTwoMarksExtenstions));


            Custom.ProgramEnd("Students with Two Marks");
            Custom.End(watch);

            //Extract Marks
            Custom.ProgramStart("Students from 2006");

            string year = "06";
            var studentsFrom2006 = listStudentsTelerik.Where(x => x.Fn[4] == '0' && x.Fn[5] == '6');
            var students2006 = listStudentsTelerik.ExtractByYear(year);
            Console.WriteLine(string.Join(Environment.NewLine, studentsFrom2006));
            Console.WriteLine(string.Join(Environment.NewLine, students2006));

            Custom.ProgramEnd("Students from 2006");
            Custom.End(watch);

            //Students From Mathematics Departament
            Custom.ProgramStart("Students From Mathematics Departament");
            string discpiline = "Mathematics";
            var studentsMath = listStudentsTelerik.Where(x => x.GroupNumber.DepartmentName == discpiline);
            Console.WriteLine(string.Join(Environment.NewLine, studentsMath));

            Custom.ProgramEnd("Students From Mathematics Departament");
            Custom.End();

            //Longest String 
            Custom.ProgramStart("Longest Firstname String");
            var longestName = listStudentsTelerik.OrderBy(x => x.FirstName.Length > x.FirstName.Length).FirstOrDefault();
            Console.WriteLine(longestName);


            Custom.ProgramEnd("Longest Firstname String");
            Custom.End();

            //Group by group Number
            Custom.ProgramStart("Group by group Number");

            var sortedByGroup = listStudentsTelerik.OrderBy(x => x.GroupNumber.GroupNumbers);
            Console.WriteLine(string.Join(Environment.NewLine, sortedByGroup));

            Custom.ProgramEnd("Group by group Number");
            Custom.End();

            //Grouped by GroupName Extensions
            Custom.ProgramStart("Grouped by GroupName Extensions");
            var grouppedByExtensions = listStudentsTelerik.GroupByNameLenght();
            Console.WriteLine(string.Join(Environment.NewLine, grouppedByExtensions));
            Custom.ProgramEnd("Grouped by GroupName Extensions");
            Custom.End();


        }

        private static void CreateStudent(out Student wordtStudent, out Student goodStudent, out Student topStudent, out Student averageStudent, out Student skatavkaStudent)
        {
            var firstGroup = new Group("Mathematics", 1);
            var secondGroup = new Group("Chemistry", 2);
            var thirdGroup = new Group("Spanish", 3);
            var fourthGroup = new Group("IT", 4);
            wordtStudent = new Student("Vladimir", "Ionkov", "285406", "0988802245", "vladovoev@abv.bg",
                           new List<double>() { 2.50, 3.50, 2.00, 3.00 },firstGroup);
            goodStudent = new Student("Petar", "Savov", "435672", "0888383505", "petar@abv.bg",
                          new List<double> { 4.00, 5.00, 6.00, 5.50 },secondGroup);
            topStudent = new Student("Mimi", "Kumanova", "456606", "0883570022", "mimi@abv.bg",
                          new List<double> { 6.00, 5.99, 6.00, 5.98 },firstGroup);
            averageStudent = new Student("Kiro", "Popov", "454552", "0882239876", "popov@abv.bg",
                  new List<double> { 5.00, 5.99, 4.00, 4.50 },thirdGroup);
            skatavkaStudent = new Student("Ali", "Xasan", "332662", "0884456789", "hackDPlanet@yahoo.bg",
                  new List<double> { 2.50,3.50},fourthGroup);

        }

        public static List<T> CreateList<T>(params T[] elements)
        {
            return new List<T>(elements);
        }

     //   public class Student
     //   {
     //       public int Age { get; set; }
     //       public string FirstName { get; set; }
     //       public string LastName { get; set; }
     //
     //       public override string ToString()
     //       {
     //           return $@"[Firstname: {this.FirstName}],[LastName: {this.LastName}],[Age: {this.Age}]";
     //       }
     //   }
    }
}
