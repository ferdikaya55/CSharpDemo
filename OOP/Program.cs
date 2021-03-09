using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            CorporateSubscriber subscriber1 = new CorporateSubscriber();
            subscriber1.Id = 1;
            subscriber1.SubscriberNo = "12345";
            subscriber1.CompanyName = "Kaya Holding";
            subscriber1.TaxNo = "123456789";
            subscriber1.TotalDebt = 122;
            subscriber1.BillNo = "12345";

            IndividualSubscriber subscriber2 = new IndividualSubscriber();
            subscriber2.Id = 2;
            subscriber2.SubscriberNo = "54321";
            subscriber2.Name = "Ferdi";
            subscriber2.LastName = "Kaya";
            subscriber2.NationalityId = "1111111111";
            subscriber1.TotalDebt = 162;
            subscriber1.BillNo = "54321";

            

            SubscriberManager subscriberManager = new SubscriberManager();
            subscriberManager.Add(subscriber1);
            subscriberManager.Add(subscriber2);

            IBillManager electricityBill = new ElectricityBillManager();
            IBillManager telephoneBill = new TelephoneBillManager();
            IBillManager gazBill = new GasBillManager();

            PaymentManager paymentManager = new PaymentManager();
            //paymentManager.Payment(electricityBill);

            List<IBillManager> bills = new List<IBillManager>() {electricityBill,telephoneBill,gazBill };
            paymentManager.ListBillCalculate(bills);
        }
    }
}
