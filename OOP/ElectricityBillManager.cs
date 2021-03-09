using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class ElectricityBillManager : IBillManager
    {
        public void Calculate()
        {
            Console.WriteLine("Elektrik faturası hesaplandı");
        }

        public void GetListBill()
        {
            throw new NotImplementedException();
        }

        public void Pay()
        {
            Console.WriteLine("Elektrik faturası ödendi");
        }
    }
}
