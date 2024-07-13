using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    internal class _9
    {
        static void Main()
        {
            int a = 0, b = 1;
            Console.Write($"{a},{b}");
            for (int i = 3; i <= 40; i++)
            {
               int c= a + b;
               Console.Write($",{c}");
               a = b;
               b=c;
            }
            
        }
    }
}
