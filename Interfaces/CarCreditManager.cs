using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class CarCreditManager : ICreditmanager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }
    }
}
