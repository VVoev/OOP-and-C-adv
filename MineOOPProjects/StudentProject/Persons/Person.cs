using MineOOPProjects.StudentProject.Person.Creature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineOOPProjects.StudentProject.Personss
{
    public abstract class Person : Creature
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Person(int age,string name) : base(age)
        {
            this.Name = name;
        }
    }
}
