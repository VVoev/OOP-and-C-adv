using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Defining_Classes_Part1_StudentProject.HeroProject
{
    class Heroes
    {
        private string name;
        private Sword sword;
        public string Name { get; set; }
        public Heroes()
          :this("noName")
        {

        }

        public Heroes(string name)
        {
            this.Name = name;
        }

        public string Armor { get; internal set; }
        public Warcry Cry { get; internal set; }
        public string Weapon { get; internal set; }
        public Sword Sword { get; internal set; }

        internal void SayYourName()
        {
            Console.WriteLine("My name is {0}",this.Name);
        }
    }
}
