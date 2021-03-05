using System;

namespace int_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 5, 8, 2, 90, 57, 25, 89, 21, 78, -9 };
            int sum = 0;
            int max = arr[0];
            int min = arr[0];
            foreach (int tem in arr)
            {
                sum += tem;
                if (tem > max) max = tem;
                if (tem < min) min = tem;
            }

            Console.WriteLine("The maxinum number is " + max);
            Console.WriteLine("The mininum number is " + min);
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("The average number is " + sum / arr.Length  * 1.0);
        }
    }
}
