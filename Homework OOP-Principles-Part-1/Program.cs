using Homework_OOP_Principles_Part_1.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Principles_Part_1
{
    class OOPPrinciples
    {
        static void Main()
        {
            // 1.School Test
            Separate("School");
            SchoolTest.Go();


            //2.StudentAndWorker Test
            Separate("Student And Worker");
            StudentAndWorker.Go();

            //3. Animal Test
            Separate("Animal");
            AnimalTest.Go();
        }
        public static void Separate(string name)
        {
            Console.WriteLine();
            Console.WriteLine($"Your Next Project {name.ToUpper()} Start here");
            Console.WriteLine();
        }
    }


}

