namespace WarMachinesFromScratch.Models
{
    using System;
    using System.Collections.Generic;
    using WarMachinesFromScratch.Interfaces;

    class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"Name cannot be null");
                }
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (this.machines == null)
            {
                throw new ArgumentException("Machine", "Machine cannot be null");
            }
            this.machines.Add(machine);
        }

        public string Report()
        {
            throw new NotImplementedException();
            //Todo add Report
        }
    }
}
