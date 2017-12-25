using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndnUseTypes
{
    //class NamedArgumentsBase
    //{
    //    public virtual void TestParam( int b, int a)
    //    {
    //        Console.WriteLine("Inside Base TestParam()");
    //    }
    //}



    //class NamedArguments :NamedArgumentsBase
    //{
    //    public override void TestParam(int a,int b)
    //    {
    //        Console.WriteLine("Inside deribved TestParam()");
    //        base.TestParam(a, b);
    //    }
    //}


    class A
    {
        public virtual void DoSomething(int x, int y)
        {
            Console.WriteLine("{0}, {1}", x, y);
        }
    }
    class B : A
    {
        public override void DoSomething(int y, int x)
        {
            base.DoSomething(y, x);
        }
    }
}
