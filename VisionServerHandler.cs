using Precise.Common.Communication.Vision.VisionEngineComm;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Brooks_TCS_Demo
{
    public class VisionServerHandler : IDisposable
    {
        public Image image;
        private string ip;
        private int port;
        private VisionEngineClientService visionEngineClientService;

        public VisionServerHandler(VisionEngineClientService visionEngineClientService)
        {
            this.visionEngineClientService = visionEngineClientService;
        }

        void IDisposable.Dispose()
        {
            Disconnect();
        }

        public void Connect(string ipAddress)
        {
            try
            {
                //string visionServerIP = "192.168.0.200";
                //if (visionEngineClientService.IsConnected == false)
                //    visionEngineClientService.Connect(visionServerIP);
                //visionEngineClientService.ImageUpdated += VisionEngineClientService_ImageUpdated;
            }
            catch (Exception e) { }


        }

        public void Disconnect()
        {
            //if (client.Connected)
            //    client.Dispose();
        }

        public Image GetImage(string cameraName = "Image1")
        {

            string url = "http://192.168.0.200:5000/CurrentImage/Image1";
            string localFilePath = "DownloadedImage.jpg";

            try
            {
                // Download the image using WebClient
                using (WebClient client = new WebClient())
                {
                    byte[] imageData = client.DownloadData(url);

                    // Convert byte array to image
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);
                        return image;
                        // Save the image to a local file
                        image.Save(localFilePath);
                        Console.WriteLine($"Image successfully downloaded and saved as {localFilePath}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return null;
        }

    }

}
