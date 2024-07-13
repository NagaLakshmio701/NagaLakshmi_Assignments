using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    internal class _17
    {
        static void Main()
        {
            Console.WriteLine("enter the word");
            string a = Console.ReadLine();
            Console.WriteLine("Reversed WORD IS");

            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }
    }
}
