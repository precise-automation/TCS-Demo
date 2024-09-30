using Precise.Common.Communication.Vision.VisionEngineComm;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
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

        public void ImageUpdated(object sender, ImageUpdatedArguments e)
        {
            int cameraNumber = e.CameraNumber;

            var camera = visionEngineClientService.Cameras.FirstOrDefault(c => c.CameraNumber == cameraNumber); //PNG or JPG

            using (var stream = new MemoryStream(camera.CameraImage.Bytes, 0, camera.CameraImage.DataLength))
            {
                using (var image = Bitmap.FromStream(stream))
                {
                    pictureBox_LiveImage.Invoke(new Action(() =>
                    {
                        string fileName = "ImageFromCamera.bmp";
                        if (pictureBox_LiveImage.Visible)
                        {
                            pictureBox_LiveImage.Visible = false;
                            pictureBox_LiveImage.Image?.Dispose();
                            File.Delete(fileName);
                        }
                        image.Save(fileName, ImageFormat.Bmp);
                        image.Dispose();
                        pictureBox_LiveImage.Image = Image.FromFile(fileName);
                        pictureBox_LiveImage.Visible = true;
                    }));
                }

            }
        }

    }

}
