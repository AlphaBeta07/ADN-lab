using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
   interface IFlyingBird
    {
        void Fly();
    }

    class Sparrow : IFlyingBird
    {
        public void Fly()
        {
            Console.WriteLine("Sparrow is flying");
        }
    }

    class Ostrich
    {
        // Ostrich does not fly
    }
    internal class Solid3
    {
    }
}
