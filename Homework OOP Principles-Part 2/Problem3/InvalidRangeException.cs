using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Homework_OOP_Principles_Part_2.Problem3
{
    public class InvalidRangeException<T> : ArgumentOutOfRangeException where T:IComparable<T>
    {
        public T Start { get; set; }
        public T End { get; set; }
        public InvalidRangeException(T start,T end)
            :base("The value is outside of the boundaries")
        {
            this.Start = start;
            this.End = end;
        }
    }
}
