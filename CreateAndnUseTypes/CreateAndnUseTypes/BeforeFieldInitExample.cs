using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndnUseTypes
{
     class  BeforeFieldInitExample
    {
        /*
         * Note we can see "beforefieldinit" metadata attribute attached to classs without static constructor in ILDASM code.
         * 
         *  In the absence of the beforefieldinit attribute, the CLR is required to call
            the type initializer before any member on the class is touched

            This means that if beforefieldinit is set on the class, you can call instance constructors
            and methods all day long without requiring the type initializer to execute first. But as soon as anything
            tries to access a static field on the class, the CLR invokes the type initializer first

            
         */
        public BeforeFieldInitExample()
        {
            Console.WriteLine("A.BeforeFieldInitExample()");
        }
        //public static int X;
        static int InitX()
        {
            Console.WriteLine("A.InitX()");
            return 1;
        }
        public int x = InitX();
    }
}
