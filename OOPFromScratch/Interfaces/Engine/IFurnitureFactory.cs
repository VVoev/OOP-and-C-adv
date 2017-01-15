using OOPFromScratch.Interfaces.Models;

namespace OOPFromScratch.Interfaces.Engine
{
    interface IFurnitureFactory
    {
        ITable CreateTable(string model, string materialType, decimal price, decimal height, decimal lenght, decimal width);

        IChair CreateChair(string model, string materialType, decimal price, decimal height, int numberOfLegs);

        IAdjustableChair CreateAdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs);

        IConvertibleChair CreateConvertibleChair(string model, string materialType, decimal price, decimal height);

        IDesk CreateDesk(string model, string materialType, decimal price, decimal height, decimal lenght, decimal width);



    }
}
