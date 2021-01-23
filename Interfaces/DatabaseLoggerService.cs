using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
