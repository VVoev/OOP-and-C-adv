using System.Collections.Generic;

namespace Homework_Defining_Classes_Part1.SchoolProject
{
    public class Teacher
    {
        private List<Disciplines> disciplines;
        private string v;

        public Teacher()
        {
        }

        public Teacher(string v, List<Disciplines> disciplines)
        {
            this.v = v;
            this.disciplines = disciplines;
        }
    }
}