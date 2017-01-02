using Homework_Defining_Classes_Part1_StudentProject.MobileProject.GSMDetals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Defining_Classes_Part1_StudentProject.MobileProject
{
    class GsmTest
    {
        public static void TestPhone()
        {
            List<Call> myCalls = new List<Call>();
            Battery testBattery = new Battery("Varta", 168, 340, BatteryType.LiIon);
            Display testDisplay = new Display(5.9, 16000000);
            GSM myLG = new GSM("G3", "LG", 600, "Vlado Voev", testBattery, testDisplay);
            FreeLine(myLG);
            Console.WriteLine(myLG);

            GSM secondLG = new GSM("G2", "LG");
            FreeLine(secondLG);
            Console.WriteLine(secondLG);

            //Display IPhone information, which is declared as static property in class GSM.
            GSM apple = new GSM();
            FreeLine(apple.Iphone7);
            Console.WriteLine(apple.Iphone7);
     
            GSM thirdLG = new GSM("G4","LG",1300,"Kiril Popov",new Battery("SuperPlus",800,1300,BatteryType.NiCd),new Display(6.6,130000));
            FreeLine(thirdLG);
            Console.WriteLine(thirdLG);

            Call firstCall = new Call(DateTime.Today, "+35983927832792", 180);
            myLG.AddCall(firstCall);
            myCalls.Add(firstCall);
            Call secondCall = new Call(DateTime.Now, "+632763276328", 1200);
            myLG.AddCall(secondCall);
            myCalls.Add(secondCall);
            Call thirdCall = new Call(DateTime.UtcNow, "+3327575489", 400);
            myLG.AddCall(thirdCall);
            myCalls.Add(thirdCall);

            Console.WriteLine("Call History Test");
            foreach (var call in myCalls)
            {
                Console.Write("Date: " + call.TimeOfCall);
                Console.Write(" Phone number: " + call.CallerPhoneNumber);
                Console.Write(" Duration: " + call.CallDuration);
                Console.WriteLine();
            }
            Console.WriteLine("Call History End Test");

            Console.WriteLine("Statistics of the Phone Calls");
            int totalDuration = myLG.CalculateTotalDuration();
            Console.WriteLine("Vashata smetka e "+myLG.CalculateTotalPrice(totalDuration)+" leva");

            Console.WriteLine("Vasheto nai dulgo obajdane e bilo {0} sekundi",myLG.MaxDuration());

            myLG.ClearallCalls();
            if (myLG.CallsCount == 0)
            {
                EndProgram(myLG);
            }





        }
        public static void FreeLine(GSM gsm)
        {
            Console.WriteLine("[]------------ Details Abour your {0}---------------------[];", gsm.Model);
        }
        public static void EndProgram(GSM gsm)
        {
            Console.WriteLine("Your new Project---------------------{0} PROJECT---------------------End Here",gsm.Model);
        }
    }
}
