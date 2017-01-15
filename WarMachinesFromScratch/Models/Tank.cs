using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachinesFromScratch.Interfaces;

namespace WarMachinesFromScratch.Models
{
    public class Tank : Machine, IMachine, ITank
    {
        private const int TankHealt = 100;
        private const int TankAttack = 40;
        private const int TackDefence = 30;

        public Tank(string name, double attackPonts, double defencePoints) : base(name, attackPonts, defencePoints, TankHealt)
        {
            this.ToggleDefenceMode();
        }

        public bool DefenceMode { get; private set; }

        public void ToggleDefenceMode()
        {
            this.DefenceMode = !this.DefenceMode;
        }

        public override string ToString()
        {
            return base.ToString();
            //Add ToString
        }
    }
}
