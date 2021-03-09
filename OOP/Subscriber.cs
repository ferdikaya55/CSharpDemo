using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    // Abone Base class' ı referans tutucudur.
   public class Subscriber
    {
        public int Id { get; set; }
        public string SubscriberNo { get; set; }
        public string BillNo { get; set; }
        public decimal TotalDebt { get; set; }
    }
}
