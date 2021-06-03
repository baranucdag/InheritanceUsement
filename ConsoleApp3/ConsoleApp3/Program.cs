using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual client1 = new Individual();
            client1.Name = "baran";
            client1.Surname = "ucdag";
            client1.Id = 1;
            client1.ClientNumber = "1";
            client1.İdentifyNumber = "1";


            Coorporate client2 = new Coorporate();
            client2.CompanyName = "yıldırım ticaret";
            client2.Id = 2;
            client2.ClientNumber = "2";
            client2.TaxNumber = "2";

            Client client3 = new Coorporate();
            Client client4 = new Individual();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(client1);
            customerManager.Add(client3);

            
        }
    }
}
