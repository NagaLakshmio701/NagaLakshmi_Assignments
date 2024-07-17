using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment3
{
    public class Building
    {
        public string Type { get; set; }
        public string Capacity { get; set; }
        public string Dimension { get; set; }
        public string FloorNumber { get; set; }
        public string LandDimension { get; set; }
        public string DateOfCompletion { get; set; }

        public Building(string type, string capacity, string dimension, string floorOrLand, string dateOfCompletion)
        {
            Type = type;
            Capacity = capacity;
            Dimension = dimension;
            DateOfCompletion = dateOfCompletion;

            if (type.ToLower() == "flat")
            {
                FloorNumber = floorOrLand;
                LandDimension = null;
            }
            else if (type.ToLower() == "villa")
            {
                LandDimension = floorOrLand;
                FloorNumber = null;
            }
            else
            {
                throw new ArgumentException("Type must be either 'Flat' or 'Villa'");
            }
        }

        public void ShowData()
        {
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Dimension: {Dimension}");

            if (Type.ToLower() == "flat")
            {
                Console.WriteLine($"Floor Number: {FloorNumber}");
            }
            else if (Type.ToLower() == "villa")
            {
                Console.WriteLine($"Land Dimension: {LandDimension}");
            }

            Console.WriteLine($"Date of Completion: {DateOfCompletion}");
        }
    }

    class two
    {
        static void Main(string[] args)
        {
            Building building1 = new Building("Flat", "3BHK", "1200 sqft", "5", "2024-12-31");
            building1.ShowData();

            Console.WriteLine();

            Building building2 = new Building("Villa", "4BHK", "2500 sqft", "60X40", "2025-06-30");
            building2.ShowData();
        }
    }

}
