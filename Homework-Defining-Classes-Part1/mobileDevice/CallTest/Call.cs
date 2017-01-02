using System;

namespace Homework_Defining_Classes_Part1.mobileDevice.CallTest
{
    public class Call
    {
        //Fields in class Call
        private DateTime dateOfCall;
        private string callerCellPhone;
        private int callDuration;

        //Properties in class Call
        public DateTime DateOfCall
        {
            get { return this.dateOfCall; }
            set { this.dateOfCall = value; }
        }
        public string CallerCellPhone
        {
            get { return this.callerCellPhone; }
            set { this.callerCellPhone = value; }
        }
        public int CallDuration
        {
            get { return this.callDuration; }
            set { this.callDuration = value; }
        }

        //Constructor in class Call
        public Call (DateTime dateOfCall,string callerCellPhone,int callDuration)
        {
            this.DateOfCall = dateOfCall;
            this.CallerCellPhone = CallerCellPhone;
            this.CallDuration = callDuration;
        }
    }
}