
namespace Homework_Defining_Classes_Part1_StudentProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Call
    {
        //Fields in class Call
        private DateTime timeOfCall;
        private string callerPhoneNumber;
        private int callDuration;

        //Properties in class Call
        public DateTime TimeOfCall
        {
            get { return this.timeOfCall; }
            set { this.timeOfCall = value; }
        }
        public string CallerPhoneNumber
        {
            get { return this.callerPhoneNumber; }
            set { this.callerPhoneNumber = value; }
        }
        public int CallDuration
        {
            get { return this.callDuration; }
            set { this.callDuration = value; }
        }
        
        //Constructor in class Call
        public Call(DateTime timeCall,string callerPhone,int callDuration)
        {
            this.TimeOfCall = timeCall;
            this.CallerPhoneNumber = callerPhone;
            this.CallDuration = callDuration;
        }


    }
}
