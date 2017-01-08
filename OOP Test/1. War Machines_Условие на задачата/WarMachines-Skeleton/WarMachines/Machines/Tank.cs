using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Tank : Machine,ITank,IMachine
    {
        private const int  tankHealPoints= 100;
        private const int  attackPointsChange= 40;
        private const int defencePointsChange = 30;
        public Tank(string name, double attackPoints, double defensePoints) : base(name, attackPoints, defensePoints,tankHealPoints )
        {
            this.DefenseMode = true;
        }
        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;
            if (this.DefenseMode)
            {
                this.AttackPoints -= attackPointsChange;
                this.DefensePoints += defencePointsChange;
            }
            else
            {
                this.AttackPoints += attackPointsChange;
                this.DefensePoints -= defencePointsChange;
            }
        }
    }
}
