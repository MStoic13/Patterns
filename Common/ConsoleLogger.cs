using System;

namespace Common
{
    public class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        {
        }

        public void LogDebug(string id, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{id} - {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void LogError(string id, string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{id} - {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void LogInformation(string id, string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{id} - {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
