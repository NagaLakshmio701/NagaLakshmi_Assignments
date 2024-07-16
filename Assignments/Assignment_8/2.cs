using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class car
    {
        public string Model { get; set; }
        public int year { get; set; }

        public void Read(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                Model = sr.ReadLine();
                Console.WriteLine(Model);
                year = int.Parse (sr.ReadLine());
                Console.WriteLine(year);

            }
        }

        public void Write(string path)
        {
            using (StreamWriter sr = new StreamWriter(path))
            {
                sr.WriteLine(Model);
                sr.Write(year);
            }
        }
    }

    class demo2
    {
        static void Main(string[] args)
        {

            car ob = new car();
            Console.WriteLine("enter car model");
            ob.Model = Console.ReadLine();
            Console.WriteLine("enter year ");
            ob.year = int.Parse(Console.ReadLine());
            Console.WriteLine("enter path");
            string path = Console.ReadLine();
            ob.Write(path);
            ob.Read(path);


        }
    }
}


