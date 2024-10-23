using Precise.Common.Communication.Controllers;
using Precise.Common.Communication.Managers.Projects.Variables;
using Precise.Common.Communication.Managers.TCS;
using Precise.Common.Core.Util;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Brooks_TCS_Demo
{
    public class ProfileManager
    {
        private List<ProfileData> profiles;
        private TCSManager tcsManager;

        public ProfileManager(TCSManager tcsManager)
        {
            profiles = new List<ProfileData>();
            this.tcsManager = tcsManager;
        }

        public void CreateNewLocation(string name)
        {
            var loc = new ProfileData(name);
        }

        public bool Exists(string name)
            => profiles.Any(x => x.FileName == name);

        private ProfileData GetProfile(string name)
            => profiles.FirstOrDefault(x => x.FileName == name);

        public string[] GetProfileList()
            => profiles.Select(x=>x.FileName).ToArray();

        public string GetLocationString(string name)
        {
            if (Exists(name) == false) return string.Empty;
            var prof = GetProfile(name);

            return prof.ToString();
        }

        public void UpdateProfile (string name, string data)
        {
            // Create new location if it doesn't exist
            if (Exists(name) == false)
            {
                var newProfile = new ProfileData(name);
                profiles.Add(newProfile);
            }

            // Get Handle to the location
            var prof = GetProfile(name);

            var properties = data.Split(' ').Where(x=>string.IsNullOrWhiteSpace(x) == false).ToArray();

            if (properties.Length == 8)
            {
                prof.Speed = float.Parse(properties[0]);
                prof.Speed2 = float.Parse(properties[1]);
                prof.Accel = float.Parse(properties[2]);
                prof.Decel = float.Parse(properties[3]);
                prof.AccelRamp = float.Parse(properties[4]);
                prof.DecelRamp = float.Parse(properties[5]);
                prof.InRange = float.Parse(properties[6]);
                prof.Straight = int.Parse(properties[7]) == 0;
            }
            else
                MessageBox.Show("Invalid number of profile arguments", "Error");
        }

        public void SendProfileToController(string name, int index = 1)
        {
            // Create new location if it doesn't exist
            if (Exists(name) == false)
            {
                var newProfile = new ProfileData(name);
                profiles.Add(newProfile);
            }

            // Get Handle to the location
            var prof = GetProfile(name);

            // Create TCS Command based on location type
            string cmd = $"Profile {index} {ToString(prof)}";

            // Send Command and Get Response 
            var response = TcsHelper.SendSingleCommand(tcsManager, cmd).Trim();
            if (response.StartsWith("0") == false)
                MessageBox.Show(response, "Error Setting Profile on Controller");
        }

        public string GetProfileString(string name)
        {
            if (Exists(name) == false) return string.Empty;
            var prof = GetProfile(name);
            return ToString(prof);
        }

        private string ToString(ProfileData data)
        {
            int straight = data.Straight ? 1 : 0;
            return $"{data.Speed} {data.Speed2} {data.Accel} {data.Decel} {data.AccelRamp} {data.DecelRamp} {data.InRange} {straight}";
        }

        public void SetDefaultProfile()
        {
            string response = TcsHelper.SendSingleCommand(tcsManager, "Profile 1 50 50 50 50 0.1 0.1 10 0");
        }
    }
}
