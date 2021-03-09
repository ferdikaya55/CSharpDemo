using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class TelephoneBillManager : IBillManager
    {
        public void Calculate()
        {
            Console.WriteLine("Telefon faturası hesaplandı");
        }

        public void GetListBill()
        {
            throw new NotImplementedException();
        }

        public void Pay()
        {
            Console.WriteLine("Telefon faturası ödendi");
        }
    }
}
