using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndnUseTypes
{
    public class A : IDisposable
    {
        private bool disposed = false;
        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // It is safe to access other objects here.
                }
                Console.WriteLine("Cleaning up object");
                disposed = true;
            }
        }
        public void Dispose()
        {
            Console.WriteLine("IN IDisposable.Dispose()");
           // Dispose(true);
           // GC.SuppressFinalize(this);
        }
        public void DoSomething()
        {
            Console.WriteLine("A.DoSomething()");
        }
        ~A()
        {
            Console.WriteLine("Finalizing");
            Dispose(false);
        }
    }
}
