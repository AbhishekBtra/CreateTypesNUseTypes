using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndnUseTypes
{
    public struct Clock
    {

        public int hours;
        public int min;
        public int seconds;


        #region PartialInitializingConstructor
        //public Clock(int hrs, int min)
        //{
        //    this.hours = hrs;
        //    this.min = min;
        //   // This contructor is compiler error coz all the fields of struct are not initialized in the constructor 
        //} 
        #endregion


        #region AllFieldsInitializationConstructor
        public Clock(int hrs, int min, int sec)
        {//proper definition of contructor, i.e. containing initialization all the fields
         //if we do not explicitlty add the constructor then by default there is non parameterized constructor
         //NOTE - structs allow parameterized contructors to be added explicitly.
            this.hours = hrs;
            this.min = min;
            this.seconds = sec;
        } 
        #endregion

    }

    public struct IAmEmpty
    {
        // I ony  have default contructor.
        
    }

    


}
