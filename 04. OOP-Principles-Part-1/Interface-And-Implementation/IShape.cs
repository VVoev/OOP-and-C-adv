using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OOP_Principles_Part_1.Interface_And_Implementation
{
    public interface IShape
    {
        void SetPosition(int x, int y);
        double CalculateSurface();
    }
}
