using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sum of array elements
            int[] arr = {};
            Console.WriteLine("Enter the number of elements in the array: ");
            int arrLength = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine("Enter element " + (i + 1) + ": ");
                int element = Convert.ToInt32(Console.ReadLine());
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = element;
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of array elements: " + sum);
        }
    }
}
