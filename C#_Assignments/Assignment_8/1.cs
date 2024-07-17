using System.Globalization;

namespace Assignment_8
{
    internal class Program
    {

        class demo1
        {
            private List<String> list;
            public demo1(List<String> list)
            {
                this.list = list;
            }
            public void Write(string s)
            {
                using (StreamWriter sw = new StreamWriter(s))
                {
                    foreach (string i in list)
                    {
                        sw.WriteLine(i);
                    }
                }
            }
            static void Main(string[] args)
            {
                Console.WriteLine("enter total number of names");
                int n = int.Parse(Console.ReadLine());
                List <string > list = new List<string>();

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"enter {i + 1} name");
                    string n1= Console.ReadLine();
                    list.Add(n1);
                }

                Console.WriteLine("enter file path to store the names");
                String s = Console.ReadLine();
                demo1 s1 = new demo1(list);
                s1.Write(s);


            }
        }
    }

}
