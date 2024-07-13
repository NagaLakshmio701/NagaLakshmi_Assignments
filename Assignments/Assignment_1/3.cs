using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    internal class _3
    {
        static void Main()
        {
            Console.WriteLine("enter two numbers");
            int a=int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = a+1; i< b; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
