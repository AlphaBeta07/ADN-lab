using System;

namespace Exp1
{
    public class SumOfArray
    {
        public static void Sum()
        {
            Console.Write("Enter size of Array:");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Elements in Array:");
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i <= size; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of array elements:" + sum);
        }
    }
}
