using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Brooks_TCS_Demo
{
    public class ProgramSettings
    {

        // Dictionary to hold all settings
        private Dictionary<string, object> settings;

        private readonly string settingsFilePath;

        // Constructor to initialize the settings and file path
        public ProgramSettings(string filePath)
        {
            settingsFilePath = filePath;
            settings = new Dictionary<string, object>();

            // Try loading settings from file, if it exists
            LoadSettings();
        }

        // Function to get a setting with a fallback to a default value
        public T Get<T>(string key, T defaultValue = default)
        {
            if (settings.ContainsKey(key) && settings[key] is T)
            {
                return (T)settings[key];
            }
            return defaultValue; // Return default if the key doesn't exist
        }

        // Function to set or update a setting
        public void Set<T>(string key, T value)
        {
            settings[key] = value;
        }

        // Save settings to file
        public void SaveSettings()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(settings, options);
            File.WriteAllText(settingsFilePath, json);
        }

        // Load settings from file
        public void LoadSettings()
        {
            if (File.Exists(settingsFilePath))
            {
                string json = File.ReadAllText(settingsFilePath);
                settings = JsonSerializer.Deserialize<Dictionary<string, object>>(json)
                            ?? new Dictionary<string, object>();
            }
        }
    }
}
