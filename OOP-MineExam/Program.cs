using OOP_MineExam.AnimalProject;
using OOP_MineExam.CarsProject;
using OOP_MineExam.StudentProject;
using OOP_MineExam.LINQProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_MineExam.CofeeProject;

namespace OOP_MineExam
{
    public class StartUp
    {
        static void Main()
        {
            Zoo.Test();
            Race.Go();
            Test.Go();
            Linq.Go();
            Cofee.Go();
            
        }
    }
}
