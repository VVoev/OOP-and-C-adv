
namespace Homework_Defining_Classes_Part1_StudentProject.MobileProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Display
    {
        //fields in class Display
        private double size;
        private long numberOfColours;



        //Property in class Display
        public double Size
        {
            get { return this.size; }
            set
            {
                if (value < 1 || value>10)
                {
                    throw new ArgumentException("Please check again your display");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public long NumberOfColours
        {
            get { return this.numberOfColours; }
            set
            {
                if (value < 16000)
                {
                    throw new ArgumentException("This display is really bad");
                }
                else
                {
                    this.numberOfColours = value;
                }
            }
        }

        //Constructor in Class Display
        public Display(double size, long numberOfColours)
        {
            this.Size = size;
            this.NumberOfColours = numberOfColours;
        }
        public override string ToString()
        {
            var displayInfo = new StringBuilder();
            displayInfo.AppendLine(string.Format("Display Size: " + this.Size));
            displayInfo.AppendLine(string.Format("Display Number Of Colours: " + this.NumberOfColours));
            return displayInfo.ToString();
        }
    }
}
