using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Extension_Methods_Delegates_Lambda_LINQ.DynamicType
{
    public class Student
    {
        public int ID { get; set; }
        public string  Name { get; set; }

        public string SayName()
        {
            return "I am " + this.Name;
        }
    }
}
