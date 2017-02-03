
namespace Homework_Defining_Classes_Part1_StudentProject.CofeeProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CofeeTest
    {
        public static void TestCofee()
        {
            //Input
            //0
            //3
            //10
            //20
            //30
            //1
            //20
            //30
            //40
            //3
            //50
            //60
            //70
            //4
            int numberOfCoffees = int.Parse(Console.ReadLine());
            var cofeeList = new List<Cofee>();
            for (int i = 0; i < numberOfCoffees; i++)              
            {
                int firstCall = i;
                Console.WriteLine("Please Select how much sugar you want: ");
                int sugar = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Select how much milk you want: ");
                int milk = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Select how much water you want: ");
                int water = int.Parse(Console.ReadLine());
                Console.WriteLine("Please select what kind of cofee do you want");
                Console.WriteLine("1 for :Black");
                Console.WriteLine("2 for :White");
                Console.WriteLine("3 for :Capuccinno");
                Console.WriteLine("4 for :Double");
                Console.WriteLine("5 for :Machiato");
                int choise = int.Parse(Console.ReadLine());
                CofeeType type = (CofeeType)choise - 1;

                Cofee clientCofee = new Cofee(firstCall, milk,sugar , water, type);                
                cofeeList.Add(clientCofee);
                //var info = Cofee.CofeeInfo(firstCall,milk,sugar,water,type);
                //Console.WriteLine("-------------------");
                //Console.WriteLine(info);
            }
            foreach (var cofee in cofeeList)
            {
                var info = Cofee.CofeeInfo(cofee.ClientCall, cofee.Milk, cofee.Sugar, cofee.Water, cofee.Type);
                //Console.WriteLine("-------------------");
                //Console.WriteLine(info);
            }
            var sortedCofeeList = cofeeList.OrderBy(x => x.Type).ThenBy(x => x.Water).ToList();
            Console.WriteLine("-----------------------------");
            Console.WriteLine(string.Join(Environment.NewLine, sortedCofeeList));

        }
    }
}
