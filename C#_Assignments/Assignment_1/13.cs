using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    internal class _13
    {
        static void Main()
        {
            Console.WriteLine("enter the first number");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the first number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the first number");
            int c = int.Parse(Console.ReadLine());

            if(a>b & a > c)
            {
                Console.WriteLine($"Largest number is :{a}");
            }
            else if(b>a & b > c)
            {
                Console.WriteLine($"Largest number is :{b}");
            }
            else
            {
                Console.WriteLine($"Largest number is :{c}");
            }
                   
        }
    }
}
