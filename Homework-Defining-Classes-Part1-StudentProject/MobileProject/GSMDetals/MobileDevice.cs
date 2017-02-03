using System.Text;

namespace Homework_Defining_Classes_Part1_StudentProject.MobileProject
{
    internal class MobileDevice
    {
        //Fields in class GSM
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;

        //Properties in class GSM
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
            set { this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
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

        //Constructors in class GSM
        

        public override string ToString()
        {
            var phoneInfo = new StringBuilder();
            phoneInfo.AppendLine(string.Format("Model: "+this.Model));
            phoneInfo.AppendLine(string.Format("Manufacturer: " +this.Manufacturer));
            if (this.Price != 0)
            {
                phoneInfo.AppendLine(string.Format("Price: "+this.Price+" Leva"));
            }
            if (this.Owner != null)
            {
                phoneInfo.AppendLine(string.Format("Owner: "+this.Owner));
            }
            if (this.Battery != null)
            {
                phoneInfo.AppendLine(string.Format("Battery Details: "+this.Battery));
            }
            if (this.Display != null)
            {
                phoneInfo.AppendLine(string.Format("Display Details: "+this.Display));
            }
            return phoneInfo.ToString();
        }
    }
}