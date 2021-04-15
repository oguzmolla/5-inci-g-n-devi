using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DbLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı");
        }
    }
}
