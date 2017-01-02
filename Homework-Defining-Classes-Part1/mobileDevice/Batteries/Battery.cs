using System;

namespace Homework_Defining_Classes_Part1
{
    //Define a class that holds information about a mobile phone device: model, manufacturer,
    //price, owner, battery characteristics (model, hours idle and hours talk)
    //and display characteristics (size and number of colors).
    public class Battery
    {
        //Fields in class Battery
        private string batteryModel;
        private double batteryHoursIdle;
        private double batteryHourTalk;
        private BatteryType batteryType;

        //Properties in class Battery
        public string BatteryModel
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }
        public double BatteryHoursIdle
        {
            get { return this.batteryHoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Your battery is corrupted");
                }
                else
                {
                    this.batteryHoursIdle = value;
                }
            }
        }
        public double BatteryHourTalk
        {
            get { return this.batteryHourTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Your battery is corrupted hours talk cannot be less than 0");
                }
                else
                {
                    this.batteryHourTalk = value;
                }
            }
        }
        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }

        //Constructors in class Battery
        public Battery(string batteryModel)
        {
            this.BatteryModel = batteryModel;
        }
        public Battery(string batteryModel,double batteryHoursIdle)
        {
            this.BatteryModel = batteryModel;
            this.BatteryHoursIdle = batteryHoursIdle;
        }
        public Battery(string batteryModel, double batteryHoursIdle,double batteryHourTalk)
        {
            this.BatteryModel = batteryModel;
            this.BatteryHoursIdle = batteryHoursIdle;
            this.BatteryHourTalk = batteryHourTalk;
        }
        public Battery(string batteryModel, double batteryHoursIdle, double batteryHourTalk,BatteryType batteryType)
        {
            this.BatteryModel = batteryModel;
            this.BatteryHoursIdle = batteryHoursIdle;
            this.BatteryHourTalk = batteryHourTalk;
            this.BatteryType = batteryType;
        }
        public Battery(string batteryModel, BatteryType batteryType)
        {
            this.BatteryModel = batteryModel;
            this.BatteryType = batteryType;
        }



    }
}