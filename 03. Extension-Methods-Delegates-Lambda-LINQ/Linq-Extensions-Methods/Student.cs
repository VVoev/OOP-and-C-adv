using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Extension_Methods_Delegates_Lambda_LINQ.Linq_Extensions_Methods
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

        public override string ToString()
        {
            return string.Format($@"Id:{this.Id}{Environment.NewLine}Name:{this.Name}{Environment.NewLine}Courses:{this.Courses.Count}{Environment.NewLine}");
        }
    }
}
