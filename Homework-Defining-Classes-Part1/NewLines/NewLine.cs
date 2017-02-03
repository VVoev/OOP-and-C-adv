using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Defining_Classes_Part1.NewLines
{
   public class NewLine
    {
        public static void NewLinez(string newProject)
        {
                Console.WriteLine();
                Console.WriteLine($@"Your new Project---------------------{newProject.ToUpper()}---------------------Starts Here");
                Console.WriteLine("[]-------------------------------------------------------------------------------------------[]");
                Console.WriteLine();
        }
    }
    
}
