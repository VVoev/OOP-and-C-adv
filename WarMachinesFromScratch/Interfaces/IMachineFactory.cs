namespace WarMachinesFromScratch.Interfaces
{
    public interface IMachineFactory
    {
        IPilot HirePilot(string name);

        ITank ManufactureTank(string name, double attackPoints, double defencePoints);

        IFighter ManufaceFighter(string name, double attackPoints, double defencePoints, bool stealMode);
    }
}
