using Precise.Common.Communication.Controllers;
using Precise.Common.Communication.Managers.Projects.Variables;
using Precise.Common.Communication.Managers.TCS;
using Precise.Common.Core.Util;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tcs.Core
{
    public class LocationManager
    {
        private List<LocationData> locations;
        private TCSManager tcsManager;

        public LocationManager(TCSManager tcsManager)
        {
            locations = new List<LocationData>();
            this.tcsManager = tcsManager;
        }

        public void CreateNewLocation(string name, LocationType locType = LocationType.Cartesian)
        {
            var loc = new LocationData("");
            loc.Name = name;
            loc.Type = locType;
        }

        public bool Exists(string name)
            => locations.Any(x => x.FileName == name);

        private LocationData GetLocation(string name)
            => locations.FirstOrDefault(x => x.FileName == name);

        public string[] GetLocationList()
            => locations.Select(x=>x.FileName).ToArray();

        public string GetLocationString(string name)
        {
            if (Exists(name) == false) return string.Empty;
            var loc = GetLocation(name);

            // Set Location
            if (loc.Type == LocationType.Cartesian)
            {
                return loc.CartesianLocation.ToString("");
            }
            else
            { 
                return loc.JointPosition.ToString("");
            }
        }


        public string UpdateLocation (string name, bool isCartesian)
        {
            LocationType locationType = isCartesian ? LocationType.Cartesian: LocationType.Angles;

            // Create new location if it doesn't exist
            if (Exists(name) ==false) 
            {
                var newloc = new LocationData(name);
                newloc.Type = locationType;
                locations.Add(newloc);
            }

            // Get Handle to the location
            var loc = GetLocation(name);

            // Create TCS Command based on location type
            string cmd = loc.Type == LocationType.Cartesian ? "WHEREC" : "WHEREJ";

            // Send Command and Get Response 
            var response = TcsHelper.SendSingleCommand(tcsManager, cmd).Trim();
            if (string.IsNullOrWhiteSpace(response)) return string.Empty;

            // Parse Response
            var components = response.Split(' ');
            if (components.Length > 5)
            {
                // Convert Response to array of doubles
                double[] doubles = components.Skip(1).Select(double.Parse).ToArray();
                
                // Set the location data
                if (loc.Type == LocationType.Angles)
                {
                    loc.JointPosition = new GplJointPosition(doubles);
                }
                else
                {
                    loc.CartesianLocation = new GplTransform(doubles);
                }
            }

            // Return string to update text box
            return string.Join(" ", components.Skip(1).ToArray());
        }

        public void UpdateLocation(string name, string pos)
        {
            // Create new location if it doesn't exist
            if (Exists(name) == false) return;

            // Get Handle to the location
            var loc = GetLocation(name);

            // Parse Response
            var components = pos.Trim().Split(' ').Where(x => string.IsNullOrWhiteSpace(x) == false).ToArray();
            if (components.Length >= 4)
            {
                // Convert Response to array of doubles
                double[] doubles = components.Select(double.Parse).ToArray();

                // Set the location data
                if (loc.Type == LocationType.Angles)
                {
                    loc.JointPosition = new GplJointPosition(doubles);
                }
                else
                {
                    loc.CartesianLocation = new GplTransform(doubles);
                }
            }

        }

        public void MoveToLocation(string name, int station = 1,  int profile = 1, bool appro = false)
        {
            string locType, pos, response = string.Empty;


            if (Exists(name) == false) return;
            var loc = GetLocation(name);

            // Set Location
            if (loc.Type == LocationType.Cartesian)
            {
                locType =  "locXyz" ;
                pos = loc.CartesianLocation.ToString("");
            }
            else
            {
                locType = "locAngles";
                pos = loc.JointPosition.ToString("");
                
            }
            response = TcsHelper.SendSingleCommand(tcsManager, $"{locType} {station} {pos}");
            if (response.StartsWith("0") == false)
                MessageBox.Show(response, "Error Returned");

            // Approach Location
            if (appro)
            {
                response = TcsHelper.SendSingleCommand(tcsManager, $"MoveAppro {station} {profile}");
                if (response.StartsWith("0") == false)
                    MessageBox.Show(response, "Error Returned");
            }

            // Move to Location
            response = TcsHelper.SendSingleCommand(tcsManager, $"Move {station} {profile}");
            if (response.StartsWith("0") == false)
                MessageBox.Show(response, "Error Returned");
        }
    }
}
