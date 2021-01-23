using ClassMetotDemo;
using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ferdi";
            customer1.LastName = "Kaya";
            customer1.Age = 24;
            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Mesut";
            customer2.LastName = "Özil";
            customer2.Age = 34;
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Ömer";
            customer3.LastName = "Kaya";
            customer3.Age = 32;

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);
            customerManager.AddCustomer(customer3);

            Customer[] customers = new Customer[] { customer1, customer2,customer3 };
            customerManager.ListCustomer(customers);

            customerManager.DeleteCustomerList(customers);

           
        }
    }
}
