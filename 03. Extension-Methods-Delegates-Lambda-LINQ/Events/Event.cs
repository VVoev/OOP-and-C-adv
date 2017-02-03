using OOP_MineExam.CustomSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAreHere
{
    class Event
    {
        public static void Go()
        {
            var x = Custom.StartProgram();
            Custom.ProgramStart("Events");
            ListWithChangedEvent list = new ListWithChangedEvent();
            Console.WriteLine("Adding item number 1");
            list.Add("item 1");
            list.Clear();

            Custom.MakeFreeLines(3);
            //attach method as a listener
            list.Changed += ListOnChanged;

            //Attaching delegate as a listener
            list.Changed += delegate (object sender, EventArgs args)
            {
                Console.WriteLine("Delegate (object sender,eventArgs args)");
            };
            //Attaching anonymous type as a listener
            list.Changed += (sender, args) => Console.WriteLine("(sender,args)=>");

            Console.WriteLine("Adding item number 2 ");
            list.Add("item number 2");

            list.Changed -= ListOnChanged;


            Console.WriteLine("Adding item number 3");
            list.Add("item number 3");


            Custom.ProgramEnd("Events");
            Custom.EndProgram(x);
            Custom.End();



        }

        private static void ListOnChanged(object sender, EventArgs e)
        {
            Console.WriteLine("ListOnChanged(Object Sender,EventArgs eventArgs)");
        }
    }
}
