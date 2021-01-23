using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class ApplyManager
    {
        // Method Injection
        public void ToApply(ICreditmanager creditManager,ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }

        public void ToCreditPreNotification(List<ICreditmanager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
