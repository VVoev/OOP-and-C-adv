using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OOP_Principles_Part_2.VirtualMethods
{
    class TestVirtual
    {
        public static void Go()
        {
            Figure[] figures = { new Line(), new Circle(), new Line(), new SpecialFigure(), new Line() };
            foreach (var f in figures)
            {
                f.Draw();
            }
        }
    }
}
