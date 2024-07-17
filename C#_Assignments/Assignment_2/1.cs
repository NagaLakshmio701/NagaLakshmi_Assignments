namespace Assingment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 1000;//assume
            double interest = 0.015;
            double TotalPayments = 0;
            int month = 1;

            Console.WriteLine("enter your monthly payment:\n");
            double Mpayment=double.Parse(Console.ReadLine());

            while(balance > 0)
            {
                balance += balance * interest;
                balance -= Mpayment;
                TotalPayments+=Mpayment;
                Console.WriteLine($"MONTH :{month}  BALANACE : {balance}  TOTAL PAYMENTS:{TotalPayments}");
                month++;
            }

            if (balance <= 0)
            {

                Console.WriteLine("Debt is clear");


            }
        }
    }
}
