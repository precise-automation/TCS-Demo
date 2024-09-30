using Precise.Common.Communication.Protocols.VisionStream.Server;
using Precise.Common.Communication.Vision.VisionEngineComm;
using Precise.Common.Communication.VisionEngineComm.Vision.Results;
using Precise.Common.Core.Language;
using Precise.Common.Core.Logging;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Brooks_TCS_Demo
{
    public class VisionServerHandler : IDisposable
    {
        public Image image;
        public event EventHandler<Image> ImageCaptured;

        public bool IsConnected
        {
            get => visionEngineClientService.IsConnected;
        }

        private string ipAddress;
        private LogService logService;
        private LanguageService languageService;
        private Func<VisionToolInstance[]> visionToolInstanceFinder;
        private ResultConverterFactory resultConverterFactory;
        private VisionDataClient visionDataClient;
        private VisionEngineClientService visionEngineClientService;

        public VisionServerHandler()
        {
            InitializeVisionComponents();
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

        private void InitializeVisionComponents()
        {
            logService = new LogService();
            languageService = new LanguageService(logService);

            visionToolInstanceFinder = () =>
            {
                return visionEngineClientService.VisionToolInstances.ToArray();
            };

            var resultsConverterFactory = new ResultConverterFactory(languageService, logService, visionToolInstanceFinder);

            visionEngineClientService = new VisionEngineClientService(languageService, logService, resultsConverterFactory);

            visionDataClient = new VisionDataClient(logService, 0);

            visionEngineClientService.ErrorDetected += VisionEngineClientService_ErrorDetected;
            visionEngineClientService.ImageUpdated += VisionEngineClientService_ImageUpdated;
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
        {
            MessageBox.Show(exception.Message, "Vision Engine Client Service Error Detected");
        }

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

        internal void LiveVideo(int camera)
        {
            visionEngineClientService.LiveVideo(camera);
        }

        internal void StopLiveVideo()
        {
            visionEngineClientService.StopLiveVideo();
        }


    }

}
