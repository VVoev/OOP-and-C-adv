namespace WarMachines.Machines
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using WarMachines.Interfaces;
    using System.Text;
    using Common;

    public class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> machines;
        public string Name
        {
          get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name", "Name cannot be null");
                }
                this.name = value;
            }
        }

        public Pilot (string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                Validator.CheckIfNull(machine,"Null machine cannot be added to pilot");
            }
            this.machines.Add(machine);
        }

        public string Report()
        {
            var sortedMachines = this.machines
                .OrderBy(x => x.HealthPoints)
                .ThenBy(x => x.Name);
            var noMachineMaybe =
                                this.machines.Count > 0 
                                ? this.machines.Count.ToString()
                                : "no";
            var plural = 
                                this.machines.Count == 1
                                ? "machine"
                                :"machines";
            var sb = new StringBuilder();
            sb.AppendLine(string.Format($"{this.Name} – {noMachineMaybe} {plural}"));
            foreach (var machine in sortedMachines)
            {
                sb.Append(machine.ToString());
            }
            return sb.ToString();
        }
    }
}
