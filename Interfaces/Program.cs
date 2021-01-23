using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // interfaceler birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız. Referans tutucudur.

            ICreditmanager personalCreditManager = new PersonalFinanceCreditManager();
            ICreditmanager carCreditManager = new CarCreditManager();
            ICreditmanager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService fileLogerService = new FileLoggerService();

            ApplyManager applyManager = new ApplyManager();
            applyManager.ToApply(carCreditManager,new DatabaseLoggerService());

            List<ICreditmanager> credits = new List<ICreditmanager>() {personalCreditManager,mortgageCreditManager};
            //applyManager.ToCreditPreNotification(credits);
        }
    }
}
