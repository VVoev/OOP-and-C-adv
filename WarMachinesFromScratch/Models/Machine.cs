using System;
using System.Collections.Generic;
using WarMachinesFromScratch.Interfaces;

namespace WarMachinesFromScratch.Models
{
    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private ICollection<string> targets;

        protected Machine(string name,double attackPonts,double defencePoints,double healtPoints)
        {

        }
        public double AttackPoints { get; protected set; }

        public double DefencePoints { get; protected set; }

        public double HealthPoints { get;  set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Name", "Name cannot be null");
                }
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }

            set
            {
                if(value == null)
                {
                    throw new ArgumentException("Pilot", "Pilot cannot ben null");
                }
                this.pilot = value;
            }
        }

        public IList<string> Targets
        {
            get { return new List<string>(this.targets); }
        }

        public void Attack(string target)
        {
            this.targets.Add(target);
        }
    }
}
