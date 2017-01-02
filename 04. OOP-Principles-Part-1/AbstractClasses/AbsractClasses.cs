using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAbstract
{
    class AbsractClasses
    {
        public static void Go()
        {
            Turtle turtle = new Turtle();
            Console.WriteLine(turtle);
            Console.WriteLine($@"The {turtle.GetName()} can go up to {turtle.Speed}km/h");
            Console.WriteLine();

            Cheetah cheetah = new Cheetah();
            Console.WriteLine(cheetah);
            Console.WriteLine($@"The {cheetah.GetName()} can go up to {cheetah.Speed}km/h");
            Console.WriteLine();
           
            Tomcat tomcat = new Tomcat();
            Console.WriteLine(tomcat);
            Console.WriteLine($@"The {tomcat.GetName()} can go up to {tomcat.Speed}km/h");
            tomcat.SayMiau();
            Console.WriteLine();
           //
            Kitten kitten = new Kitten();
            Console.WriteLine(kitten);
            Console.WriteLine($@"The {kitten.GetName()} can go up to {kitten.Speed}");
            kitten.SayMiau();
            Console.WriteLine();

            


        }
    }
}
