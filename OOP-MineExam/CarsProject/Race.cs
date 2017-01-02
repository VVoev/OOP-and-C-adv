using OOP_MineExam.CarsProject.Driver;
using OOP_MineExam.CarsProject.Movable.Manufacturer;
using OOP_MineExam.CustomSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MineExam.CarsProject
{
    public class Race
    {
        public static void Go()
        {
            //Start Program
            Custom.ProgramStart("Cars");
            Custom.MakeFreeLines(2);

            List<Car> Racelist = new List<Car>();
            BMW thirdSeries = new BMW(2.98, 4, true, true, 2,4.3);
            Mercedes cClass = new Mercedes(6.3, 4, false, false, 4, true,3.8);
            Audi a4 = new Audi(3.2, 4, false, true, true, false, 4.4);
            Racelist.Add(thirdSeries);
            Racelist.Add(cClass);
            Racelist.Add(a4);



            foreach (var car in Racelist)
            {
                car.GetEngineSize();
                car.MakeDonuts();
                Console.WriteLine(car);
                Custom.MakeFreeLines(2);
            }
            var credits = new List<Credits>();
            Player playerOne = new Player("Vlado", 31, thirdSeries);
            Player playerTwo = new Player("Mimi", 22, a4);
            Player playerThree = new Player("Spas", 28, cClass);
            var allPlayers = new List<Player>();
            allPlayers.Add(playerOne);
            allPlayers.Add(playerTwo);
            allPlayers.Add(playerThree);

            //var sorted = allPlayers.Where(x => x.Name.Length > 4);
            //Console.WriteLine(string.Join(" ",sorted));



            //End Program
            Custom.ProgramEnd("Cars");
            Custom.MakeFreeLines(2);
            Custom.End();
        }
    }
}
