using Common;
using System;

namespace Patterns
{
    class PatternsApp
    {
        static void Main(string[] args)
        {
            string id = $"{nameof(PatternsApp)}.{nameof(Main)}";
            ConsoleLogger consoleLogger = new ConsoleLogger();

            consoleLogger.LogInformation(id, "Welcome to Patterns in C#!");
            
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
