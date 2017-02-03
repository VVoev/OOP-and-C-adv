using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Common_Type_System.ValueAndReferenceTypesss
{
    //reference
    class RefClass
    {
        private int value;

        public int Value { get { return this.value; } set { this.value = value; } }
    }
    //value
    struct ValueStruct
    {
        private int value;

        public int Value { get { return this.value; } set { this.value = value; } }
    }
    class ValueAndReferenceTypes
    {
        public static void Go()
        {
            RefClass refExample = new RefClass();
            refExample.Value = 100;
            RefClass refExample1 = refExample;
            refExample1.Value = 200;
            Console.WriteLine(refExample.Value);
            //200

            ValueStruct valExample = new ValueStruct();
            valExample.Value = 100;
            ValueStruct valExample1 = valExample;
            valExample1.Value = 200;
            Console.WriteLine(valExample.Value);

        }
    }
}
