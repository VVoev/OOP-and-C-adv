namespace WarMachinesFromScratch.Interfaces
{
    public interface ITank : IMachine
    {
        bool DefenceMode { get; }

        void ToggleDefenceMode();
    }
}
