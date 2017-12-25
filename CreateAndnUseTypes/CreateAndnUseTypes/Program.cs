using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndnUseTypes
{
    class Program
    {

        static string bannerName;
        static int objCounter;
        static Program()
        {
            
            bannerName = "The first one to be called i.e when the class is loaded and i am alive till the program is alive in memory";

        }

        
        
        public Program()
        {
           
            objCounter = objCounter + 1;
        }
        static void Main(string[] args)
        {

            // Program p = new Program();
            //p.OnlyCallStructFns(p);
            //p.Enums();
            //  p.CallConstructors();
            //   p.bannerName; // error - coz static mmebers are single copy for class and not for every instance of class. 

            //Console.WriteLine(bannerName);
            //StaticClass.ToStrings();

            //Program p1 = new Program();
            //Console.WriteLine("\n\n\t\tObjects created = {0}",objCounter);


            //Rectangle rectangle = new Rectangle();
            //Circle circle = new Circle();
            //Drawing drawing = new Drawing();
            //drawing.Add(rectangle);
            //drawing.Add(circle);
            //for (int i = 0; i < drawing.Count; ++i)
            //{
            //    GeometricShape shape = drawing[i];
            //    shape.Draw();
            //}

            //MyValue my = new MyValue();
            //my.x = 123;
            //IPrint ip = my;

            //my.Print();
            //ip.Print();
            //BeforeFieldInitExample ob = new BeforeFieldInitExample();
            // A a = new A();


            //try
            //{
            //    a.DoSomething();
            //}
            //finally
            //{
            //    a.Dispose();

            //}
            //using (A a = new A())
            //{
            //    a.DoSomething();
            //}
            TeamMember tm = new TeamMember("Milton Waddams","");

            //Console.WriteLine(BeforeFieldInitExample.st.ToString());
            Console.ReadKey();
        }

        /*
         * An enumeration type provides an efficient way to define a set of 
         * NAMED INTEGRAL CONSTANTS
         * that may be assigned to a variable
         */
        public enum Days //Every enumeration type has an underlying type(default int), which can be any integral type except char.
        {
           Sunday ,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday
        }

        public enum EvenNUmLessThan10  : uint
        {
            //2,4,6,8 error 
            //"2","2","2" error
            ab,cd,ef,gh

            
        }
        public void Enums()
        {
            Days d = Days.Sunday;
            int d_int = (int)Days.Sunday + 9;
            Console.WriteLine("{0}    {1}", d, d_int);

            Console.WriteLine("First day is {0} i.e {1}", (int)Days.Sunday, Days.Sunday);

            Console.WriteLine("Fifthday is {0} i.e {1}", 5, (Days)5);
        }

        public void CallConstructors()
        {
            // Constructors c = new Constructors();//  error cause its private contructor
            // Constructors c1 = new Constructors(5);

            //  DerivedClass ob = new DerivedClass();
            DerivedClass ob = new DerivedClass(null);
        }


        public void OnlyCallStructFns(Program p)
        {
            p.AccessAll();
            p.CheckEquivalence();
            p.CopiedByBalue();
        }
        public void AccessAll()
        {

            /*Working with empty struct  - start*/
            IAmEmpty i;// initialized w/o new operator , i variable on stack , by default the default 0 param contructor is called
            Console.WriteLine("HashCode of i ={0}",i.GetHashCode());
            /*Working with empty struct -  end*/


            #region NonEmptyStruct
            /*Working with non empty struct  - start*/
            Clock c;
            c.hours = 5;
            c.min = 10;
            //c.seconds = 14;


            //Console.WriteLine("hours = {0} min = {1} sec ={2}", c.hours, c.min, c.seconds);
            //Console.WriteLine("structs can be initialized w/o NEW operator - hash = {0}",c.GetHashCode()); 
            //these above 2 stmts are compiler error coz all fields of struct are not assigned.


            Clock c1;
            c1.hours = 5;
            c1.min = 10;
            c1.seconds = 14;

            Console.WriteLine("hours = {0} min = {1} sec ={2}", c1.hours, c1.min, c1.seconds);
            Console.WriteLine("structs can be initialized w/o NEW operator - hash = {0}", c1.GetHashCode());
            /*Working with non empty struct  - end*/
            #endregion


        }

        public void CheckEquivalence()
        {
            #region nonempty
            Console.WriteLine("\n I check quivalence of value types");

            Clock c;
            c.hours = 10;
            c.min = 5;
            c.seconds = 54;
            Clock c1;
            c1.hours = 9;
            c1.min = 5;
            c1.seconds = 54;

            if (c.Equals(c1))
                Console.WriteLine("Equal");
            else
            Console.WriteLine("Not Equal");//Answer - coz all fields dont match i.e. hours are different
            #endregion

            #region empty
            IAmEmpty i,j;
            if (i.Equals(j))
                Console.WriteLine("Equal"); //Anser - coz empty with no fields
            else
            Console.WriteLine("Not Equal");

            #endregion
        }

        public void CopiedByBalue()
        {
            Clock c1;
            c1.hours = 5;
            c1.min = 10;
            c1.seconds = 14;

            Clock c2 = c1;

            c2.hours = 21;
            Console.WriteLine("C1.hours ={0} and c2.hours = {1}",c1.hours,c2.hours); //ans - C1.hours = 5 and c2.hours = 21 coz both have their own copy
        }
    }
}
