using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "222222";
            customer1.FirstName = "Ferdi";
            customer1.LastName = "Kaya";
            customer1.TcNo = "22222222222";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "1111";
            customer2.CompanyName = "Kaya Holding";
            customer2.TaxNumber = "343798134912";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer3);
        }
    }
}
