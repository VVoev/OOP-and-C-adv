
namespace Homework_Defining_Classes_Part1.SchoolProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SchoolTest
    {
        public static void TestSchool()
        {
            School mineSchool = new School();

            List<Disciplines> disciplines = new List<Disciplines>();
            Teacher teacher = new Teacher("Petar Petrov",disciplines);
            disciplines.Add(new Disciplines("Algebra", 4, 4));
            disciplines.Add(new Disciplines("Fizika", 3, 3));
            disciplines.Add(new Disciplines("Ximiq", 2, 2));



        }
    }
}
