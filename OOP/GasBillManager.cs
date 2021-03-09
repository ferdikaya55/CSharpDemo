using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class GasBillManager : IBillManager
    {
        public void Calculate()
        {
            Console.WriteLine("Doğalgaz faturası hesaplandı");
        }

        public void GetListBill()
        {
            throw new NotImplementedException();
        }

        public void Pay()
        {
            Console.WriteLine("Doğalgaz faturası ödendi");
        }
    }
}
