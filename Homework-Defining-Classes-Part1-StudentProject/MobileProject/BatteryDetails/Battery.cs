
namespace Homework_Defining_Classes_Part1_StudentProject.MobileProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Battery
    {
        //Fields in class Battery
        private string model;
        private int hoursIdle;
        private int hourTalk;
        private BatteryType type;

        //Properties in class Battery
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public int HourTalk
        {
            get { return this.hourTalk; }
            set { this.hourTalk = value; }
        }
        public BatteryType Type
        {
            get{return this.type;}
            set { this.type = value; }
        }

        //Constructor in class Battery
        public Battery(string model,int hoursIdle, int hoursTotalk,BatteryType type)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HourTalk = hoursTotalk;
            this.Type = type;
        }

        public override string ToString()
        {
            var batteryInfo = new StringBuilder();
            batteryInfo.AppendLine(string.Format("Battery model: " + this.Model));
            batteryInfo.AppendLine(string.Format("Battery Hours Idle: " + this.HoursIdle));
            batteryInfo.AppendLine(string.Format("Battery Hours Talk: " + this.HourTalk));
            batteryInfo.AppendLine(string.Format("Battery Type: " + this.Type));
            return batteryInfo.ToString();
        }
    }
}
