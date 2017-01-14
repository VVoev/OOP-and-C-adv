using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MineExam.CarsProject.Driver
{
    public class Credits
    {
        private List<Credits> players;
        public int MyProperty { get; set; }
        public List<Credits> Players
        {
            get { return this.players; }
            set { this.players = value; }
        }
        public Credits(string name, int age, Car car)
            :base()
        {
            this.players = new List<Credits>();
        }
        public Credits()
        {

        }
    }
}
