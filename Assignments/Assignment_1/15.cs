using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    internal class _15
    {
        static void Main()
        {
            Console.WriteLine("ENTER 10 MARKS");
            int[ ] a=new int[10];
            for ( int i = 0; i < a.Length; i++)
            {
                a[i]=int.Parse(Console.ReadLine());
            }

            //15.A TOTAL MARKS
            int  total = 0;
            for ( int i = 0;i < a.Length; i++)
            {
                total += a[i];
            }
            Console.WriteLine($"TOTAL MARKS : {total}");

            //15.B AVERAGE MARKS
            double average = (double) total / a.Length;
            Console.WriteLine($" AVERAGE MARKS :{average}");

            //15.C MINIMUM MARKS
            int minimum = a.Min();
            Console.WriteLine($" MINIMUM MARKS: {minimum}");

            //15.D MAXIMUM VALUES 

            int maximum = a.Max();
            Console.WriteLine($" MAXIMUM MARKS: {maximum}");

            //15.E ASCENDING ORDER
            Array.Sort( a );
            Console.WriteLine("MARKS IN Ascending Order");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]},");
            }

            //15.F DECENDING ORDER
            Console.WriteLine("MARKS IN Decending Order");

            Array.Reverse( a );
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]},");
            }
        }
    }
}

