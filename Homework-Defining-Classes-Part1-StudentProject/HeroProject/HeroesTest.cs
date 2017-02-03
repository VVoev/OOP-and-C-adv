using Homework_Defining_Classes_Part1_StudentProject.HeroProject;
using System;

namespace Homework_Defining_Classes_Part1_StudentProject
{
    internal class HeroesTest
    {
        internal static void TestHeroes()
        {
            //Sword
            //Iron
            //1
            Heroes barbarian = new Heroes("Konan");
            Console.WriteLine("Please choose Sword Or Axe");
            string weapon = Console.ReadLine();
            barbarian.Weapon = weapon;
            Console.WriteLine("Please choose Leather or Iron armor");
            string armor = Console.ReadLine();
            barbarian.Armor = armor;
            Console.WriteLine("Please choose your battle cry");
            Console.WriteLine("1 for damage");
            Console.WriteLine("2 for armor");
            Console.WriteLine("3 for rage");
            Warcry cry = (Warcry)int.Parse(Console.ReadLine())-1;
            barbarian.Cry = cry;
            var sword = new Sword();
            barbarian.SayYourName();
            Heroes amazon = new Heroes();
            amazon.SayYourName();
            Heroes konan = new Heroes();
        }
    }
}