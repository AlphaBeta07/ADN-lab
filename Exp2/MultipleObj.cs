using System;
using System.Collections.Generic;
using System.Text;

namespace Exp2
{
    class MultipleObj
    {
        string color = "red";
        public static void multipleObj()
        {
            MultipleObj myObj1 = new MultipleObj();
            MultipleObj myObj2 = new MultipleObj();
            Console.WriteLine("Car object1:" + myObj1.color);
            Console.WriteLine("Car object2:" + myObj2.color);
        }
    }
}
