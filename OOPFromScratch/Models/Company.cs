namespace OOPFromScratch.Models
{
    using OOPFromScratch.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name,string registrationNumber)
        {
            this.furnitures = new List<IFurniture>();
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return this.furnitures;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            protected set
            {
                this.registrationNumber = value;
            }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public string Catalog()
        {
            throw new NotImplementedException();
        }

        public IFurniture Find(string model)
        {
            return this.furnitures.FirstOrDefault(x => x.Model.ToLower() == model.ToLower());
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }
    }
}
