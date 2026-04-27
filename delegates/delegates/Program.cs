using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    internal class Program
    {
        public void func1()
        {
            Console.WriteLine("func1 called");
        }

        public delegate void myDelegate();
        static void Main(string[] args)
        {
           Program obj = new Program();
           myDelegate del = new myDelegate(obj.func1);
            del += obj.func1;
           del();

        }
    }
}
