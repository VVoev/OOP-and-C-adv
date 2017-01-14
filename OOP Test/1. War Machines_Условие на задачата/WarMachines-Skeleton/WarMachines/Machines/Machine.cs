using System;
using System.Collections.Generic;
using WarMachines.Common;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public abstract class Machine : IMachine
    {
        private string name;
        private double attackPoints;
        private double defencePoitns;
        private IPilot pilot;
        private IList<string> targets;

        protected Machine(string name, double attackPoints, double defensePoints,double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckIfNull(value);
                Validator.CheckIfStringIsNullOrEmpty(value);
                this.name = value;
            }
        }
        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public double HealthPoints { get; set; }

       

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }

            set
            {
                Validator.CheckIfNull(value, "Pilot cannot be null");
                this.pilot = value;
            }
        }

        public IList<string> Targets
        {
            get
            {
                return new List<string>(this.targets);
            }
        }

        public void Attack(string target)
        {
            Validator.CheckIfStringIsNullOrEmpty(target);
            this.targets.Add(target);
        }
    }
}
