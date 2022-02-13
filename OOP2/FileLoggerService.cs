using System;

namespace OOP2
{
    internal class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("logged to file");
        }
    }
}
