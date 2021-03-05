using System;
using System.IO;

namespace Common
{
    public class FileLogger : ILogger
    {
        private const string DefaultLogFileName = "log.log";
        private FileInfo logFile;

        public FileLogger()
        {
            this.logFile = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), DefaultLogFileName));
        }

        public FileLogger(FileInfo logFile)
        {
            this.logFile = new FileInfo(logFile.FullName);
        }

        public FileLogger(string logFileName)
        {
            this.logFile = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), logFileName));
        }

        public void LogDebug(string id, string message)
        {
            throw new NotImplementedException();
        }

        public void LogError(string id, string message)
        {
            throw new NotImplementedException();
        }

        public void LogInformation(string id, string message)
        {
            throw new NotImplementedException();
        }
    }
}
