using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineOOPProjects.StudentProject.Person.Creature
{
    public abstract class Creature
    {
        private int age;

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }


        public Creature(int age)
        {
            this.Age = age;
        }
        public virtual void Talk()
        {

        }



    }
}
