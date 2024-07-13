using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssignmentOne
{
    internal class _6
    {
        static void Main()
        {
            Console.WriteLine("Enter temperature in Fahrenheit:");
            float F = float.Parse(Console.ReadLine());
            float C = (F - 32) * 5 / 9;

            Console.WriteLine($"Temperature in Celsius: {C}");
        }
    }
}

