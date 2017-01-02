using OOP_MineExam.CustomSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Extension_Methods_Delegates_Lambda_LINQ.Delegates_Example
{
    class DelegateTest
    {
        public static void Go()
        {
            var watch = Custom.StartProgram();
            Custom.ProgramStart("Delegates");
            Custom.MakeFreeLines(2);

            SimpleDelagate d = DelegatesExample.TestMethod;
            d("XyZ");
            Custom.MakeFreeLines(2);
            CountBaby c = DelegatesExample.TestCounter;
            c += DelegatesExample.MultiPlyCounter;
            c(10);



            Custom.EndProgram(watch);
            Custom.ProgramEnd("Delegates");
            Custom.End();


        }
    }
}
