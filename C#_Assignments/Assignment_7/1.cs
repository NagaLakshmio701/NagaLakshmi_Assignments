namespace Assignment_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>();
            Console.WriteLine("enter 10 numbers");
            for (int i = 0; i < 10; i++)
            {
                int j = int.Parse(Console.ReadLine());
                l1.Add(j);
            }

            l1.Sort();
            Console.WriteLine("The 10 Numbers in Ascending Order");
            foreach (int i in l1)
            {
                Console.WriteLine(i);
            }

        }


    }
}
