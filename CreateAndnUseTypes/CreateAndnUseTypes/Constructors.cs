using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndnUseTypes
{
    /*Note - base keyword - The base keyword is used to access members of the base class *FROM WITHIN* a derived clas*/
    class Constructors
    {
        private Constructors()
        {

        }

        public Constructors(int x = 10)
        {
            Console.WriteLine("Constructing X={0}",x);
        }

    }

    class BaseClass
    {
        public string name;
        public string div;


        public BaseClass()
        {
            Console.WriteLine("In Base cons 1");
            this.name = "def";
            this.div = "def";

        }

        public BaseClass(string name = "dome",string div = "A")
        {
            Console.WriteLine("In Base cons 2");
            this.div = div;
            this.name = name;
        }


    }

    class DerivedClass : BaseClass
    {
        public DerivedClass ()
        {
            Console.WriteLine("In der cons");
        }

        public DerivedClass(string name) : base()
        {
            /*
            Any parameters to the constructor can be used as parameters to base, or as part of an expression
            */
            name = base.name;
            Console.WriteLine("In der cons with name ={0}",name);
        }
    }
}
