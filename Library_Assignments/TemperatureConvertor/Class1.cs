namespace TemperatureConvertor
{
    public class Temperature
    {



        public double CTF(double temp)
        {
            return (temp - 32) * 5 / 9;
        }

        public double FTC(double temp)
        {
            return (temp * 9 / 5) + 32;
        }

       
    }
}
