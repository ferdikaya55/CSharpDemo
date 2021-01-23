using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class MortgageCreditManager : ICreditmanager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");

        }
    }
}
