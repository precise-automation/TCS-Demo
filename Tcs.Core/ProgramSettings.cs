using Precise.Common.Core.Settings;
using System.IO;
using System.Threading;

namespace Tcs.Core
{
    public class ProgramSettings
    {

        public string Robot1IP = "127.0.0.1";
        public string Vision1IP = "127.0.0.1";
        public string Robot2IP = "127.0.0.1";
        public string Vision2IP = "127.0.0.1";

        public bool ApplySettngs = false;

        private readonly string settingsFilePath;

        private SettingsFilePersister settingsPersister;
        public SettingsService settingsService { get; private set; }

        // Constructor to initialize the settings and file path
        public ProgramSettings(string filePath)
        {
            settingsFilePath = filePath;
            if (File.Exists(settingsFilePath) == false)
            {
                File.Create(settingsFilePath);
                Thread.Sleep(3000);
            }
            settingsPersister = new SettingsFilePersister(settingsFilePath);
            settingsService = new SettingsService(settingsPersister);
            GetSettings();
        }

        public void GetSettings()
        {
            Robot1IP = settingsService.GetSetting<string>("Robot1ControllerIP", "192.168.0.1");
            Vision1IP = settingsService.GetSetting<string>("Robot1VisionIP", "192.168.0.200");
            Robot2IP = settingsService.GetSetting<string>("Robot2ControllerIP", "192.168.0.1");
            Vision2IP = settingsService.GetSetting<string>("Robot2VisionIP", "192.168.0.200");
        }

        // Update Variable and Save Varible File if Varaible Has Changed
        public void SaveSettings()
        {
            settingsService.UpdateSetting<string>("Robot1ControllerIP", Robot1IP);
            settingsService.UpdateSetting<string>("Robot1VisionIP", Vision1IP);
            settingsService.UpdateSetting<string>("Robot2ControllerIP", Robot2IP);
            settingsService.UpdateSetting<string>("Robot2VisionIP", Vision2IP);
        }

    }
}
