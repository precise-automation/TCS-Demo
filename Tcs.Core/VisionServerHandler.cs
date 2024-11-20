using Precise.Common.Communication.Protocols.VisionStream.Server;
using Precise.Common.Communication.Vision.VisionEngineComm;
using Precise.Common.Communication.VisionEngineComm.Vision.Results;
using Precise.Common.Core.Language;
using Precise.Common.Core.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Tcs.Core
{
    public class VisionServerHandler : IDisposable
    {
        public event EventHandler<Image> ImageCaptured;
        public event EventHandler<EventArgs> VisionProcessUpdated;

        public bool IsConnected
        {
            get => visionEngineClientService.IsConnected;
        }

        private Image image;
        private VisionDataClient visionDataClient;
        private VisionEngineClientService visionEngineClientService;

        public VisionServerHandler()
        {
            var logService = new LogService();
            var languageService = new LanguageService(logService);

            Func<VisionToolInstance[]> visionToolInstanceFinder = () =>
            {
                return visionEngineClientService.VisionToolInstances.ToArray();
            };

            var resultsConverterFactory = new ResultConverterFactory(languageService, logService, visionToolInstanceFinder);

            visionEngineClientService = new VisionEngineClientService(languageService, logService, resultsConverterFactory);

            visionDataClient = new VisionDataClient(logService, 0);

            visionEngineClientService.ErrorDetected += VisionEngineClientService_ErrorDetected;
            visionEngineClientService.ImageUpdated += VisionEngineClientService_ImageUpdated;
        }

        void IDisposable.Dispose()
        {
            Dispose();
        }

        public void Dispose()
        {
            visionEngineClientService.Disconnect();
            visionEngineClientService.ErrorDetected -= VisionEngineClientService_ErrorDetected;
            visionEngineClientService.ImageUpdated -= VisionEngineClientService_ImageUpdated;
            image?.Dispose();
        }

        public void Connect(string ipAddress = "192.168.0.200")
        {
            if (visionEngineClientService.IsConnected == false)
                visionEngineClientService.Connect(ipAddress);
        }


        public void Disconnect()
        {
            if (visionEngineClientService.IsConnected)
                visionEngineClientService.Disconnect();
        }

        private void VisionEngineClientService_ErrorDetected(Exception exception)
            => MessageBox.Show(exception.Message, "Vision Engine Client Service Error Detected");

        private void VisionEngineClientService_ImageUpdated(object sender, ImageUpdatedArguments e)
        {
            int cameraNumber = e.CameraNumber;

            var camera = visionEngineClientService.Cameras.First(c => c.CameraNumber == cameraNumber); //PNG or JPG

            using (var stream = new MemoryStream(camera.CameraImage.Bytes, 0, camera.CameraImage.DataLength))
            {
                using (var img = Bitmap.FromStream(stream))
                {
                    ImageCaptured.Invoke(this, img);
                }
            }
        }

        public void TriggerCamera(int cameraNumber = 1)
        {

            if (visionEngineClientService.IsConnected)
            {
                visionEngineClientService.AcquireImage(cameraNumber);
            }
            else
            {
                MessageBox.Show("Camera Not Connected");
            }
        }

        public void LiveVideo(int camera)
            => visionEngineClientService.LiveVideo(camera);
        
        public void StopLiveVideo()
            => visionEngineClientService.StopLiveVideo();

        public string[] GetVisionProjects()
        {
            return visionEngineClientService.AvailableProjects;
        }

        public string[] LoadVisionProject (string name)
        {
            visionEngineClientService.LoadProject(name);
            visionEngineClientService.RunVisionProcess(name);
            return visionEngineClientService.VisionProcesses.Select(v => v.ProcessName).ToArray();
        }

        public TreeNode[] GetVisionProcessTreeNodes(string name)
        {
            
            var process = visionEngineClientService.VisionProcesses.Where(p => p.ProcessName ==  name).FirstOrDefault();
            if (process == null) return null;

            process.Check(); // Required for Connects Process with the Tool Instances (visionEngineClientService.VisionToolInstances)

            var nodes = new List<TreeNode>();
            foreach (var tool in process.VisionTools)
            {
                nodes.Add(new TreeNode(tool.VisionTool.InstanceName));
            }
            return nodes.ToArray();
        }

        public string[] GetToolTypes()
        { 
            return visionEngineClientService.VisionToolTypes.Select(t => t.DisplayName).ToArray();
        }

        public string[] GetVisionToolInstances()
        {
            var tools = visionEngineClientService.VisionToolInstances;
            var toolNames = tools.Select(t => t.InstanceName).ToArray();
            return toolNames;
        }

        public int[] GetCameraNumbers()
        {
            var cameras = visionEngineClientService.Cameras.Select(c=> c.CameraNumber).ToArray();
            return cameras;
        }

        public void AddVisionTool(string toolTypeName, int camera)
        {
            var toolType = GetToolType(toolTypeName);
            if (toolType == null) {
                MessageBox.Show("Unrecognized Tool Type", "Error: AddVisionTool()");
                return;
            }
            string toolName = toolType.DisplayName;
            int ii = 1;
            while (GetToolInstance( toolName + ii.ToString()) != null) {
                ii++;
            }
            toolName = toolName + ii.ToString();

            visionEngineClientService.CreateVisionTool(toolType.TypeName, camera, toolName);
        }

        public void AddToolToProcess(string toolName, string processName)
        {
            var process = GetVisionProcess(processName);
            var tool = GetToolInstance(toolName);

            if (process == null)
            {
                MessageBox.Show("Invalid Process Selected", "Error: AddToolToProcess");
                return;
            }
            if (tool == null)
            {
                MessageBox.Show("Invalid Tool Selected", "Error: AddToolToProcess");
                return;
            }
            
            var tools = process.VisionTools.Select(t => t.VisionTool.InstanceName).ToList();
            tools.Add(toolName);
            visionEngineClientService.UpdateProcess(processName, tools.ToArray());
        }

        private VisionProcess GetVisionProcess(string processName)
        {
            return visionEngineClientService.VisionProcesses.FirstOrDefault(p => p.ProcessName == processName);
        }

        private VisionToolInstance GetToolInstance(string toolName)
        {
            return visionEngineClientService.VisionToolInstances.FirstOrDefault(t => t.InstanceName == toolName);
        }
        private VisionToolType GetToolType(string toolTypeName)
        {
            return visionEngineClientService.VisionToolTypes.FirstOrDefault(t => t.DisplayName == toolTypeName);
        }

        //visionEngineClientService.CreateVisionProcess

        public void SaveVisionProject(string projectName)
        {
            if(visionEngineClientService.ActiveProjectName == projectName) 
                visionEngineClientService.SaveProject();
        }

        public void Execute(string process)
        {
            visionEngineClientService.RunVisionProcess(process);
        }

        public bool IsValidToolType(string toolType)
        {
            return visionEngineClientService.VisionToolTypes.Any(t=> t.DisplayName == toolType);
        }
        
        public void CreateNewVisionProject(string name)
        {
            visionEngineClientService.ClearProject();
            System.Threading.Thread.Sleep(2000);
            visionEngineClientService.CreateVisionProcess("Process 1");
            System.Threading.Thread.Sleep(2000);
            visionEngineClientService.SaveProjectAs(name);
        }

        //tool.Properties.FirstOrDefault(p => p.DisplayName == "Left AruCo");
        //public void CreateArUcosForSteroLocate()
        //{
        //    var service = visionEngineClientService;
        //    string targetName = "StereoLocate";
        //    if (service.AvailableProjects.Any(s => s == targetName))
        //        service.DeleteProject(targetName);
        //    service.ClearProject();
        //    service.CreateVisionProcess("Cam1");
        //    service.VisionProcesses[]
        //    service.CreateVisionProcess("Cam2");
        //}
    }

}
