namespace WarMachinesFromScratch.Interfaces
{
    public interface IFighter : IMachine
    {
        bool StealthMode { get; }

        void ToggleStealthMode();
        
    }
}
