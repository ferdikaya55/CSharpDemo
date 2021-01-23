using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
   public class CustomerManager
    {
      public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " isimli müşteri eklendi.");
        }

        public void ListCustomer(Customer[] customers)

        {
            Console.WriteLine("Müşteri Listesi");
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.Id}\n{customer.FirstName}\n{customer.LastName}\n{customer.Age}");
                Console.WriteLine("*********");
            }
        }
        public void DeleteCustomerList(Customer[] customers)
        {
            Array.Clear(customers, 0,customers.Length);
            Console.WriteLine("Liste silindi");
        }
      
    }
}
