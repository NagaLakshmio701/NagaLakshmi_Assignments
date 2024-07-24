using TemperatureConvertor;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature obj = new Temperature();

            double Fahrenheit = obj.CTF(23);

            Console.WriteLine("Fahrenheit : {0}", Fahrenheit);

            double Celcius = obj.FTC(12);

            Console.WriteLine("CELCIUS: {0} ",Celcius );





        }
    }
}
