using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates
{
    delegate void myDel();
    internal class Program
    {
        public void f1()
        {
            Console.WriteLine("Function1 Called");
        }
         
        public void f2()
        {
            Console.WriteLine("Function2 Called");
        }
      
        static void Main(string[] args)
        {
            Program p = new Program();
            myDel md =  p.f1;
            md();  
        }
    }
}
