using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    internal class Assignment_7

    {
        static void Main(string[] args)
        {

            List<string> l2 = new List<string>();
            Console.WriteLine("enter 10  Names");
            for (int i = 0; i < 10; i++)
            {
                string j = Console.ReadLine();
                l2.Add(j);
            }

            l2.Sort();
            l2.Reverse();
            Console.WriteLine("The 10 Numbers in decending Order");
            foreach (string  i in l2)
            {
                Console.WriteLine(i);
            }


        }

    }

}
