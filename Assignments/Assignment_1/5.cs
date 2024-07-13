using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    internal class _5
    {
        static void Main()
        {

            Console.WriteLine("enter array size");
            int n=int.Parse(Console.ReadLine());    
            int[] a = new int[n];
            for(int i = 0; i < n;i++)
            {
                Console.WriteLine($"enetr a[{i}]");

                a[i] =int.Parse( Console.ReadLine());
            }
            int evencount=0, oddcount=0;
            foreach(int i in a)
            {
                if (i % 2 == 0)
                {
                    evencount++;
                }
                else
                {
                    oddcount++;
                }
            }

            Console.WriteLine($"Total even numbers accepted by the user : {evencount}\nTotal odd numbers accepted by the user :{oddcount}");


        }



    }
} 
