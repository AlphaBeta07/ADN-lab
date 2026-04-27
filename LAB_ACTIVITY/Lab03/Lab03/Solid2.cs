using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    abstract class Discount
    {
        public abstract double GetDiscount();
    }

    class StudentDiscount : Discount
    {
        public override double GetDiscount() => 10;
    }

    class SeniorDiscount : Discount
    {
        public override double GetDiscount() => 20;
    }
    internal class Solid2
    {
        
    }
}
