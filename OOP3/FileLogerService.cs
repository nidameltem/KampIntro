using System;

namespace OOP3
{
    class FileLogerService : ILogerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }
}
