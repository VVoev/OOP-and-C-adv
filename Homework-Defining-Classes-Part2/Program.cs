using Homework_Defining_Classes_Part2.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_Defining_Classes_Part2.GenericProject;
using Homework_Defining_Classes_Part2.CustomList;
using Homework_Defining_Classes_Part2.MatrixProject;
using Homework_Defining_Classes_Part2.AttributesProject;


namespace Homework_Defining_Classes_Part2
{
    class StartUp
    {
        static void Main(string[] args)
        {

            //From another Exam outside of the Telerik Academy
            //TestCustomList.Test();
            //        1
            TestPoint.TestExam();
            //        2
            GenericTest.TestGeneric();
            //        3
            MatrixTest.Matrix();
            //        4
            AtributesTest.Test();

        }
    }
}
