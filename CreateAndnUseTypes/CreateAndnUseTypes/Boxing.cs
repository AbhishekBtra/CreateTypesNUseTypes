using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndnUseTypes
{

    public interface IPrint
    {
        void Print();
    }
    public struct MyValue : IPrint
    {
        public int x;
        public void Print()
        {
            System.Console.WriteLine("{0}", x);
        }

        void IPrint.Print()
        {
            System.Console.WriteLine("{0}", x);
        }
    }

}
