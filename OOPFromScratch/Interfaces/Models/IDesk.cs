namespace OOPFromScratch.Interfaces.Models
{
    public  interface IDesk : IFurniture
    {
        decimal Width { get; }

        decimal Lenght { get; }

        decimal Area { get; }
    }
}
