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

namespace Brooks_TCS_Demo
{
    public class VisionServerHandler : IDisposable
    {
        public event EventHandler<Image> ImageCaptured;

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
            => MessageBox.Show(exception.Message, 
                "Vision Engine Client Service Error Detected");

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
        //visionEngineClientService.VisionToolTypes
        //visionEngineClientService.CreateVisionTool
        //visionEngineClientService.CreateVisionProcess
        //visionEngineClientService.UpdateProcess
        //visionEngineClientService.SaveProject


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
