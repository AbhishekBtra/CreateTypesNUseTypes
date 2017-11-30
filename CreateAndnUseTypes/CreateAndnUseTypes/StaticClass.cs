using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndnUseTypes
{
    static class StaticClass
    {
        #region OnlyStaticFieldsAllowed
        static string name;
        static string div;
        static string sub; 
        #endregion

        #region Constructors
        //public StaticClass()
        //{
        //    //Static class cannot have instance constructor
        //}
        //public static StaticClass()
        //{
        //    //Access modifiers are not allowed to static constructors
        //}

        static StaticClass()
        {
            Console.WriteLine("I am static constructor inside static class.");
        } 
        #endregion

        public static  void ToStrings()
        {
            
            Console.WriteLine( "I am static method");
        }
    }
}
