using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OOP_Principles_Part_2.ExceptionDemo
{
   public  class InvalidCalculationException : ApplicationException
    {
        public InvalidCalculationException (string msg)
            :base(msg)
        {

        }
        public InvalidCalculationException(string msg,System.Exception innerEx)
            : base(msg,innerEx)
        {

        }
    }
}
