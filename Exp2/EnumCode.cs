using System;
using System.Collections.Generic;
using System.Text;

namespace Exp2
{
    internal class EnumCode
    {
        enum Level
        {
            Low,
            Medium,
            High
        }
        public static void enumCode()
        {
            Level myVar = Level.Medium;
            Console.WriteLine("Level Value:" + myVar);
        }
    }
}
