namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WarMachines.Interfaces;

    class Fighter : Machine, IFighter, IMachine
    {
        private const int fighterHealthPoints = 200;
        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode) : base(name, attackPoints, defensePoints, fighterHealthPoints)
        {
            this.StealthMode = stealthMode;
        }

        public bool StealthMode { get; set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }
    }
}
