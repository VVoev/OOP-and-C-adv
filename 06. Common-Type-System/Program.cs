using _06.Common_Type_System.BoxingUnboxingPrimitiveTypes;
using _06.Common_Type_System.DynamicTypes;
using _06.Common_Type_System.Implementing_IComparable;
using _06.Common_Type_System.Implementing_IEnumerable;
using _06.Common_Type_System.IsAndAsOperators;
using _06.Common_Type_System.NullableTypess;
using _06.Common_Type_System.PassingOutParametersss;
using _06.Common_Type_System.PassingRefParameterssss;
using _06.Common_Type_System.System.Object_Overloading;
using _06.Common_Type_System.ValueAndReferenceTypesss;
using Common_Type_System.Boxing_and_Unboxing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Common_Type_System
{
    class StartUp
    {
        static void Main()
        {
            //1. Boxing and Unboxing 
            Separate("Boxing and Unboxing ");
            BoxingUnboxing.Go();

            //2. BoxingUnboxingPrimitiveTypes
            Separate("BoxingUnboxingPrimitiveTypes");
            BoxingUnboxingPrimitives.Go();

            //3. DynamicTypesExample
            Separate("DynamicTypesExample");
            DynamicTypesExample.Go();

            //4. Implementing_IComparable
            Separate("Implementing IComparable");
            ImplementingIComparable.Go();

            //5. Implementing_IEnumerable
            Separate("Implementing IEnumerable");
            ImplementingIEnumerable.Go();

            //6. NullableTypes
            Separate("NullableTypes");
            NullableTypes.Go();

            //7. ValueAndReferenceTypes
            Separate("ValueAndReferenceTypes");
            ValueAndReferenceTypes.Go();

            //8. OverloadingSystemObject
            Separate("OverloadingSystemObject");
            OverloadingSystemObject.Go();

            //9. PassingOutParameters
            Separate("PassingOutParameters");
            PassingOutParameters.Go();

            //10. PassingRefParameters
            Separate("PassingRefParameters");
            PassingRefParameters.Go();

            //11. ObjectCloning
            Separate("ObjectCloning");
            ObjectCloning.Go();

            //12. IsAndAsOperators
            Separate("IsAndAsOperators");
            PalyWithOperatorsIsAndAs.Go();


        }
        private static void Separate(string name)
        {
            Console.WriteLine();
            Console.WriteLine($"----------------Your Project {name} Stars here");
            Console.WriteLine();
        }
    }
}
