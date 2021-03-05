namespace Common
{
    public interface ILogger
    {
        void LogInformation(string id, string message);
        void LogDebug(string id, string message);
        void LogError(string id, string message);
    }
}
