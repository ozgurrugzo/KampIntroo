using OOP3;
using System;

internal class FileLoggerService : ILoggerService
{
    public void Log()
    {
        Console.WriteLine("Dosyaya loglandı");
    }
}
