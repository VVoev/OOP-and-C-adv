using System;

namespace Homework_Defining_Classes_Part1
{
    public class MobilePhone
    {
        // Fields in class MobilePhone
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;

        // Properties in class MobilePhone
        public string Model
                {
                    get { return this.model; }
                    set { this.model = value; }
                }
        public string Manufacturer
                {
                    get { return this.manufacturer; }
                    set { this.manufacturer = value; }
                }
        public decimal Price
                {
                    get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price can't be less than 0!");
                }
                else
                {
                    this.price = value;
                }
            }

        }
        public string Owner
                {
                    get { return this.owner; }
                    set
            {
                if (value == string.Empty)
                {
                    this.owner = null;
                }
                else
                {
                    this.owner = value;
                }
            }
                }
        public Battery Battery
                {
                    get { return this.battery; }
                    set { this.battery = value; }
                }
        public Display Display
                {
                    get { return this.display; }
                    set { this.display = value; }
                }

        //Constructors in class MobilePhone


    }
}