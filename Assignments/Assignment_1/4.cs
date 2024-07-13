using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    internal class _4
    {
        static void Main()
        {
            Console.WriteLine("enter value");
            int n=int.Parse(Console.ReadLine());
            string Result=(n % 2 == 0) ? "EVEN" : "ODD";
            Console.WriteLine(Result);
        }
    }
}
