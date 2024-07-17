using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    internal class _14
    {
        static void Main()
        {
            int[] numbers = new int[5];
            Console.WriteLine("enter five values ");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int smallest = numbers.Min();

            Console.WriteLine($"Smallest number is :{ smallest}");
        }
    }
}
