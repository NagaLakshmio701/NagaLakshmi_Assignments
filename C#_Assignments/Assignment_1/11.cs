using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    internal class _11
    {
        static void Main()
        {
            Console.WriteLine("enter number <= 20");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine($"Multiplication table of {n}");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
        }
    }
}
