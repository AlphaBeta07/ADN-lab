using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace Exp4
{
    public class SortingList
    {
        public static void SortList()
        {
            List<string> names = new List<string>() { "Kia" , "Porche" , "Nissan" , "Toyota" , "Audi" , "Volvo"};

            names.Sort((first,second) => first.CompareTo(second));
            Console.WriteLine("Names in Aescending Order:");
            names.ForEach(name => Console.WriteLine(name));

            Console.WriteLine();    

            names.Sort((first, second) => second.CompareTo(first));
            Console.WriteLine("Names in Descending Order:");
            names.ForEach(name => Console.WriteLine(name));

        }
    }
}
