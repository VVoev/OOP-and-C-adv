using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_2_Live.GenericConstraints
{
    public class GenericConstraintszz
    {
        public static void Test()
        {
            GenericConstraintClass<TestClass1> test1 = new GenericConstraintClass<TestClass1>();
        }
    }
    class TestClass1 : BaseClass, IInterface
    {
    }

    class TestClass2 : BaseClass
    {
    }

    class TestClass3 : BaseClass, IInterface
    {
        public TestClass3(int param)
        {
        }
    }

    class BaseClass
    {
    }

    interface IInterface
    {
    }

    class GenericConstraintClass<T>
        where T : BaseClass, IInterface, new()
    {
        public T Method1(T param)
        {
            return param;
        }
    }
}
