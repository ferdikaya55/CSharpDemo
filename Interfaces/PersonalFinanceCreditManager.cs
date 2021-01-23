using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class PersonalFinanceCreditManager : ICreditmanager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");

        }
    }
}
