using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class PaymentManager
    {
        // Dependency Injection
        public void Payment(IBillManager billManager)
        {
           
            billManager.Pay();
        }
        public void ListBillCalculate(List<IBillManager> bills)
        {
            foreach (var bill in bills)
            {
                bill.Calculate();
            }
        }
    }
}
