using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList List = new ArrayList();
            List.Add(10);
            List.Add(20);
            List.Add("C#"); //this is not typesafety.

            //generics
            List<int> num = new List<int>();
            num.Add(10);
            num.Add(20);
            // num.Add("#"); //it is not right 

            myClass<int> obj1 = new myClass<int>();
            obj1.Data = 20;

            myClass<String> obj2 = new myClass<String>();
            obj2.Data = "Shravani";
        }
    }
     class myClass<T>
     {     
        public T Data;
        public void Show()
        {
            Console.WriteLine(Data);
        }
     }
 }


//generics allows us to define classes ,methods and collections with a placeholder for a datatype so they work with any type while maintaining type safety.

//activity 
//write 2 ex with generics
//realtime use of generics in company
//why comapny uses generics(typesafety)


//lamda expression is short way of writing anonomous method using arrow operator
//(parameter) => expression 
//activity -
//write 2 examples of lymbda expression 
//where we use it in company
//create a generic class to store two values
//what generics?
//why generics are better than arraylist?
//what is lymda expression?
//diff between deligates and lymda?


//Synchronous AND Asynchronous  