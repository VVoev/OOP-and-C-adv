using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Common_Type_System.PassingRefParameterssss
{
    public struct Point
    {
        internal int x, y;
    }
    public class MultiPlyPoint
    {
        public static void IncorrectMultiplyByTwo(Point point)
        {
            point.x *= 2;
            point.y *= 2;
        }
        public static void MultiplyByTwo(ref Point point)
        {
            point.x *= 2;
            point.y *= 2;
        }
    }
    public class Student
    {
        public string name;
        public Student(string name)
        {
            this.name = name;
        }
    }
    class PassingRefParameters
    {
        public static void Go()
        {
            Console.WriteLine("Test passing class (reference type) by reference:");
            Student s = new Student("Telerik Academy");
            Console.WriteLine(s.name);
            IncorrectChangeName(s);
            Console.WriteLine(s.name);
            CorrectChangename(ref s);
            Console.WriteLine(s.name);

            Console.WriteLine("Test passing struct (value type) by reference:");
            Point p = new Point() { x = 5, y = 10 };
            Console.WriteLine("p=({0},{1})", p.x, p.y);
            MultiPlyPoint.IncorrectMultiplyByTwo(p);
            Console.WriteLine("p=({0},{1})", p.x, p.y);
            MultiPlyPoint.MultiplyByTwo(ref p);
            Console.WriteLine("p=({0},{1})", p.x, p.y);




        }
        static void IncorrectChangeName(Student student)
        {
            student = new Student("changed" + student.name);
        }
        static void CorrectChangename(ref Student student)
        {
            student = new Student("changed" + student.name);
        }
    }
}
