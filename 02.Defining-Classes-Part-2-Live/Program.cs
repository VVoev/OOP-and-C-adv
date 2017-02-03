using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Defining_Classes_Part_2_Live.NewLinezzz;
using Defining_Classes_Part_2_Live.Generic_Classes;
using Defining_Classes_Part_2_Live.GenericConstraints;
using Defining_Classes_Part_2_Live.GenericMethodzzz;
using Defining_Classes_Part_2_Live.Indexerss;
using Defining_Classes_Part_2_Live.Overloading_Operatorssss;
using Defining_Classes_Part_2_Live.StaticMembersss;
using Defining_Classes_Part_2_Live.Structuresss;

namespace Defining_Classes_Part_2_Live
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------1----------------------//
            Lines.MakeNewLines("Attributes",1);
            //UsingAttributes.TestAtribute();
            Lines.MakeFinishLines("Attributes");

            //--------------------2----------------------//
            Lines.MakeNewLines("Custrom Atributes",2);
            CustomAttributesDemo.TestCustom();
            Lines.MakeFinishLines("Custrom Atributes");

            //--------------------3----------------------//
            Lines.MakeNewLines("Generic Classes",3);
            GenericListExample.TestGeneric();
            Lines.MakeFinishLines("Generic Classes");

            //--------------------4----------------------//
            Lines.MakeNewLines("GenericConstraints",4);
            GenericConstraintszz.Test();
            Lines.MakeFinishLines("GenericConstraints");

            //--------------------5----------------------//
            Lines.MakeNewLines("GenericMethod",5);
            GenericMethod.Test();
            Lines.MakeFinishLines("GenericMethod");

            //--------------------6----------------------//
            Lines.MakeNewLines("Indexers", 6);
            Indexers.TestIndex();
            Lines.MakeFinishLines("Indexers");

            //--------------------7----------------------//
            Lines.MakeNewLines("NameSpace", 7);
            //Namespace
            Lines.MakeFinishLines("NameSpace");

            //--------------------8----------------------//
            Lines.MakeNewLines("Overloading Operators", 8);
            Overloading_Operators.TestOperators();
            Lines.MakeFinishLines("Overloading Operators");

            //--------------------9----------------------//
            Lines.MakeNewLines("Static Members", 9);
            StaticMembers.TestStatic();
            Lines.MakeFinishLines("Static Members");

            //--------------------10----------------------//
            Lines.MakeNewLines("Structure", 10);
            Structuree.TestStructure();
            Lines.MakeFinishLines("Structure");




        }
    }
}
