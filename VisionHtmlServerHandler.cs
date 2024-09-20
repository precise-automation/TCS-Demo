using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Brooks_TCS_Demo
{
    public class VisionHtmlServerHandler : IDisposable
    {
        public Image image;
        public TcpClient client = new TcpClient();
        private string ip;
        private int port;

        public VisionHtmlServerHandler(string ip = "192.168.0.200", int port = 5000)
        {
            this.ip = ip;
            this.port = port;
        }

        void IDisposable.Dispose()
        {
            Disconnect();
        }

        public void Connect()
        {
            try
            {
                client.Connect(ip, port);
            }
            catch (Exception e) { }


        }

        public void Disconnect()
        {
            if (client.Connected)
                client.Dispose();
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
