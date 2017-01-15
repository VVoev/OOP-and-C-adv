using System.Collections.Generic;

namespace WarMachinesFromScratch.Interfaces
{
    public interface IMachine
    {
        string Name { get; set; }

        IPilot Pilot { get; set; }

        double HealthPoints { get; set; }

        double AttackPoints { get; }

        double DefencePoints { get; }

        IList<string> Targets { get; }

        void Attack(string target);

        string ToString();
    }
}
