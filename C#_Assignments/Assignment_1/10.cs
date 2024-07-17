using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    internal class _10
    {
        static void Main()
        {
            Console.WriteLine("enter integer N");
            int N =int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i*i*i;
            }
            Console.WriteLine(sum);
        }
    }
}
