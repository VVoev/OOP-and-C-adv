namespace OOPFromScratch.Engine.Factories
{
    using System;

    using OOPFromScratch.Interfaces;
    using OOPFromScratch.Interfaces.Engine;
    using OOPFromScratch.Interfaces.Models;
    public class FurnitureFactory : IFurnitureFactory
    {
        private const string Wooden = "wooden";
        private const string Leather = "leather";
        private const string Plastic = "plastic";
        private const string Invalid = "Invalid material name: {0}";

        private MaterialType GetMaterialType(string material)
        {
            switch (material)
            {
                case Wooden:return MaterialType.Wooden;
                case Leather:return MaterialType.Leather;
                case Plastic:return MaterialType.Plastic;
                default: throw new ArgumentException(string.Format(Invalid, material));
            }
        }

        public IAdjustableChair CreateAdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            return new AdjustableChair(model, materialType, price, height, numberOfLegs);
        }

        public IChair CreateChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            return new Chair(model, materialType, price, height, numberOfLegs);
        }

        public IConvertibleChair CreateConvertibleChair(string model, string materialType, decimal price, decimal height)
        {
            return new ConvertibleChair(model, materialType, price, height);
        }

        public IDesk CreateDesk(string model, string materialType, decimal price, decimal height, decimal lenght, decimal width)
        {
            return new Desk(model, materialType, price, height, lenght, width);
        }

        public ITable CreateTable(string model, string materialType, decimal price, decimal height, decimal lenght, decimal width)
        {
            return new Table(model, materialType, price, height, lenght, width);
        }
    }
}
