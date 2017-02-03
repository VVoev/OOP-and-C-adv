using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Extension_Methods_Delegates_Lambda_LINQ.LambaExpressions
{
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format($@"Name:{this.Name}{Environment.NewLine}Age:{this.Age}{Environment.NewLine}");
        }
    }
}
