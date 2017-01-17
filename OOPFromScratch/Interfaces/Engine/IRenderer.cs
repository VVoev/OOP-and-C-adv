using System.Collections.Generic;

namespace OOPFromScratch.Interfaces.Engine
{
    public interface IRenderer
    {
        IEnumerable<string> Input();

        void Output(IEnumerable<string> output);
    }
}
