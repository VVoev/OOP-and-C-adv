using System.Collections.Generic;

namespace WarMachinesFromScratch.Interfaces
{
    public interface ICommand
    {
        string Name { get; }

        IList<string> Parameters { get; }
    }
}
