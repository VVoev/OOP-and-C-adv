using Homework_OOP_Principles_Part_1.SchoolClasses.Schools.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Principles_Part_1.SchoolClasses.Schools
{
    class School
    {
        //fields
        private IEnumerable<SchoolClass> schoolClasses;

        //Property
        public IEnumerable<SchoolClass> SchoolClasses { get { return this.schoolClasses; } set { this.schoolClasses = value; } }

        //constructor
        public School()
        {

        }

        public School(IEnumerable<SchoolClass> classesInSchool)
        {
            this.SchoolClasses = classesInSchool;
        }

        //methods
        public override string ToString()
        {
            return string.Format($"Clases \r\n + {String.Join(Environment.NewLine, this.SchoolClasses)}");
        }
    }
}
