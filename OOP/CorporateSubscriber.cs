using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    // Kurumsal Abone
    public class CorporateSubscriber:Subscriber
    {
       
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
