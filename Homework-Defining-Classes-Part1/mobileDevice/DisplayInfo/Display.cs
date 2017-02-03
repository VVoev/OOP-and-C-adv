using System;

namespace Homework_Defining_Classes_Part1
{
    public class Display
    {
        //Fields in class Display
        private double displaySize;
        private int numberOfColours;

        //Properties in class Display
        public double DisplaySize
        {
            get { return this.displaySize; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Screen cannot be negative");
                }
                else if (value < 2.5)
                {
                    throw new ArgumentOutOfRangeException("Screen should be more than 2.5 inchs long");
                }
                else
                {
                    this.displaySize = value;
                }
            }
        }
        public int NumberOfColours
        {
            get { return this.numberOfColours; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Colors cannot be less than 0");
                }
                else
                {
                    this.numberOfColours = value;
                }
            }
        }

        //Constructors in class Display
        public Display(double displaySize,int displayNumberOfColours)
        {
            this.DisplaySize = displaySize;
            this.NumberOfColours = displayNumberOfColours;
        }

    }
}