using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    internal class _19
    {
        static void Main()
        {
            Console.WriteLine("enter the word");
            string a = Console.ReadLine();
            int t = 0;
            for (int i = 0, j = a.Length - 1; i < j; i++, j--)
            {
                if (a[i] != a[j])
                {
            
                    t++;
                }

            }

            if (t == 0)
            {
                Console.WriteLine("word is polindrome");
            }
            else
            {
                Console.WriteLine("word is not polindrome");
          
            }


        }
    }
}
