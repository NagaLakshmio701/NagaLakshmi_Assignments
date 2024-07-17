using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    internal class _8
    {
        static void Main()
        {
            Console.WriteLine("enter the number");
            long a=long.Parse(Console.ReadLine());
            long f = 1;
            for (int i = 1;i<= a;i++)
            {
                f = f * i;
            }
            Console.WriteLine($"factorial of {a} : {f}");
        }
    }
}
