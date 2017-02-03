using _05.OOP_Principles_Part_2.PolymorphismDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OOP_Principles_Part_2.ExceptionDemo
{
   public class Exception
    {
        public static void Go()
        {
            Console.WriteLine(SimleExceptionClass.CalcSize(new Rectangle(){ Width = 5, Height = 5.2 }));
            Console.WriteLine(SimleExceptionClass.CalcSize(new Circkle(){ Radius=4.2 }));
            Console.WriteLine(SimleExceptionClass.CalcSize("Hello"));
            Console.WriteLine(SimleExceptionClass.CalcSize(42));
            Console.WriteLine(SimleExceptionClass.CalcSize(1.55));
           // Console.WriteLine(SimleExceptionClass.CalcSize(DateTime.Now));

        }
    }
    public class SimleExceptionClass 
    {
        public static double CalcSize(object obj)
        {
            if(obj is Figure)
            {
                return ((Figure)obj).CalculateSurface();
            }
            if (obj is string)
            {
                return ((string)obj).Length;
            }
            try
            {
                return (double)(dynamic)obj;
            }
            catch (System.Exception ex)
            {
                throw new InvalidCalculationException("Cannot calculate the size of the specified object");
                
            }
        }
    }
}
