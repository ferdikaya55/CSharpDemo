using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer
            {
                DateOfBirthDay =
                new DateTime(1996, 15, 06),
                Firstname = "Ferdi",
                Lastname = "Kaya",
                NationalId = "3333333333"
            });
            Console.ReadLine();
        }
    }
}
