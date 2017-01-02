using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionSB;
using ExtensionIenumerable;
using StudentOp;
using Divese7And3;
using TimerDelegate;

namespace _03.Homework_Extension_Methods_Delegates_Lambda_LINQ
{
    class Homework_Linq
    {
        static void Main(string[] args)
        {
            //1. Extension StringBuilder.Substring
            ExtensionStringBuilder.Go();

            //2. IEnumerable Extension
            //sum, product, min, max, average.
            ExtensionIEnumerable.Go();

            //Problem 3,4,5
            StudentOperations.Go();

            //Problem Divisible by 7 and 3
            Divisibleby7and3.Go();

            //Timer
            DelegateTimerF.Go();

            //Events 
            //Missing

            //Students 9-19
            StudentOperations.LinqStudents();

            //Delegates
            //Missing


        }
    }
}
