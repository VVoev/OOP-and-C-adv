using System;
using WarMachinesFromScratch.Interfaces;
using WarMachinesFromScratch.Models;

namespace WarMachinesFromScratch.Engine
{
    class MachineFactory : IMachineFactory
    {
        public IPilot HirePilot(string name)
        {
            return new Pilot(name);
        }

        public IFighter ManufaceFighter(string name, double attackPoints, double defencePoints, bool stealMode)
        {
            return new Fighter( name,  attackPoints,  defencePoints);
        }

        public ITank ManufactureTank(string name, double attackPoints, double defencePoints)
        {
            return new Tank(name, attackPoints, defencePoints);
        }
    }
}
