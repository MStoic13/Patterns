namespace Common
{
    public interface IConfiguration
    {
        string GetProperty(string propertyName, string defaultValue);
        int GetProperty(string propertyName, int defaultValue);
    }
}
