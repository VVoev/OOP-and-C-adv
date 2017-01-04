using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Common_Type_System.System.Object_Overloading
{
    class OverloadingSystemObject
    {
        public static void Go()
        {
            Student firstStudent = new Student();
            firstStudent.FirstName = "Petar";
            firstStudent.Age = 68;
            Console.WriteLine(firstStudent); //called firstStudent.ToString()

            Student secondStudent = new Student();
            if (firstStudent != secondStudent)
                Console.WriteLine($"{firstStudent}!={secondStudent}"); // it is true

            secondStudent.FirstName = "Iliq";
            secondStudent.Age = 30;
            if(firstStudent==secondStudent)
                Console.WriteLine($"{firstStudent}=={secondStudent}");

            secondStudent.Age = 70;
            if (firstStudent != secondStudent)  // it is true
                Console.WriteLine("{0} != {1}", firstStudent, secondStudent);

            Console.WriteLine(firstStudent.GetHashCode());
            Console.WriteLine(firstStudent.Equals(secondStudent));

        }
    }
}
