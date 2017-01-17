using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachinesFromScratch.Interfaces;

namespace WarMachinesFromScratch.Engine
{
    public sealed class WarMachineEngine : IWarMachineEngine
    {
        private static WarMachineEngine instance;
        public static WarMachineEngine Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new WarMachineEngine();
                }
                return instance;
            }
        }

        public void Start()
        {
            var commands = this.ReadCommands();
            var commandResult = this.ProcessCommands(commands);
            this.PrintReports(commandResult);
        }
    }
}
