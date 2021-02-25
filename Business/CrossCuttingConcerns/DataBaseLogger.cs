using System;

namespace Business.CrossCuttingConcerns
{
    public class DataBaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}
