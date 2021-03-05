using System;
using System.Collections.Generic;
using System.IO;

namespace Common
{
    public class Configuration : IConfiguration
    {
        private Dictionary<string, string> _propertiesAndValues;

        public Configuration(FileLogger logger, string configFilePath)
        {
            string id = $"{nameof(Configuration)}.{nameof(Configuration)}";

            _propertiesAndValues = new Dictionary<string, string>();

            FileInfo configFile = new FileInfo(configFilePath);
            if (!configFile.Exists)
            {
                logger.LogError(id, $"File {configFilePath} not found. Cannot parse config.");
            }
            else
            {
                ParseConfiguration(configFile);
            }
        }

        private void ParseConfiguration(FileInfo configFile)
        {
            throw new NotImplementedException();
        }

        public string GetProperty(string propertyName, string defaultValue)
        {
            throw new System.NotImplementedException();
        }

        public int GetProperty(string propertyName, int defaultValue)
        {
            throw new System.NotImplementedException();
        }
    }
}
