using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    internal class _18
    {
        static void Main()
        {
            Console.WriteLine("enter the first word");
            string a = Console.ReadLine();
            Console.WriteLine("enter the second word");
            string b = Console.ReadLine();
            if(a == b)
            {
                Console.WriteLine("Two strings are Same");
            }
            else
            {
                Console.WriteLine("Two strings are Not Same");
            }
        }
    }
}
