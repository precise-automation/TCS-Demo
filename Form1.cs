using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Brooks_TCS_Demo
{
    public partial class Form1 : Form
    {

        private VisionServerHandler robot1Vision;
        private RobotServerHandler robot1Controller;

        private Image cameraImageDisplay;
        private ProgramSettings programSettings;

        private string robot1ControllerIP;
        private string robot1VisionIP;

        public Form1()
        {
            InitializeComponent();
            InitializeSettings();
            UpdateRobotConnectionStatus();
            UpdateVisionConnectionStatusDisplay();
            robot1Controller = new RobotServerHandler();
            robot1Controller.ConnectionChanged += Robot1Controller_ConnectionChanged;

            robot1Vision = new VisionServerHandler();
            robot1Vision.ImageCaptured += Robot1Vision_ImageCaptured;
        }



        private void InitializeSettings()
        {
            string settingsFilePath = "settings.json";
            programSettings = new ProgramSettings(settingsFilePath);
            LoadSettings();
        }

        private void LoadSettings(bool forceReload = false)
        {
            if (forceReload)
                programSettings.LoadSettings();

            robot1ControllerIP = programSettings.Get<string>("Robot1ControllerIP", "192.168.0.1");
            robot1VisionIP = programSettings.Get<string>("Robot1VisionIP", "192.168.0.200");

            //    Example Code:
            //    int volume = programSettings.Get<int>("volume", 50); // Default to 50 if not found
            //    string theme = programSettings.Get<string>("theme", "light"); // Default to "light"
        }

        private void SaveSettings()
        {
            programSettings.Set("Robot1ControllerIP", robot1ControllerIP);
            programSettings.Set("Robot1VisionIP", robot1VisionIP);
            programSettings.SaveSettings();

            //    Example Code: 
            //    programSettings.Set("volume", 75);
            //    programSettings.Set("theme", "dark");
        }


        private void VisionConnect()
        {
            UpdateVisionConnectionStatusDisplay();
            if (robot1Vision.IsConnected == false)
            {
                robot1Vision.Connect(robot1VisionIP);
                UpdateVisionConnectionStatusDisplay(true);
            }
        }


        private void VisionDisconnect()
        {
            UpdateVisionConnectionStatusDisplay();

        }

        private void UpdateVisionConnectionStatusDisplay(bool connected = false)
        {
            if (connected)
            {
                toolStripStatusLabel_VisionConnection.Text = "Connected";
                toolStripStatusLabel_VisionConnection.ForeColor = Color.Green;
            }
            else
            {
                toolStripStatusLabel_VisionConnection.Text = "Disconnected";
                toolStripStatusLabel_VisionConnection.ForeColor = Color.Red;

            }
        }

        private void VisionAquireSingle(int camera = 1)
        {
            robot1Vision.TriggerCamera(camera);
        }


        private void button_TriggerCamera_Click(object sender, EventArgs e)
        {
            VisionAquireSingle();
        }

        private void RobotConnect()
        {
            robot1Controller.Connect(robot1ControllerIP);
        }
        private void RobotDisconnect()
        {
            robot1Controller.Disconnect();
        }

        private void Robot1Controller_ConnectionChanged(object sender, EventArgs e)
        {
            pictureBox_LiveImage.Invoke(new Action(() => { UpdateRobotConnectionStatus(); }));
        }

        private void Robot1Vision_ImageCaptured(object sender, Image img)
        {
            pictureBox_LiveImage.Invoke(new Action(() => { UpdateImageDisplay(img); }));
        }

        public void UpdateImageDisplay(Image img)
        {

            // Option 1
            //pictureBox_LiveImage.Visible = false;
            //pictureBox_LiveImage.Image?.Dispose();
            //cameraImageDisplay = img;
            //pictureBox_LiveImage.Image = cameraImageDisplay;

            // Option 2
            string fileName = "ImageFromCamera.bmp";
            if (pictureBox_LiveImage.Visible)
            {
                pictureBox_LiveImage.Visible = false;
                pictureBox_LiveImage.Image?.Dispose();
                File.Delete(fileName);
            }
            img.Save(fileName, ImageFormat.Bmp);
            img.Dispose();
            pictureBox_LiveImage.Image = Image.FromFile(fileName);

            pictureBox_LiveImage.Visible = true;
        }

        public void UpdateRobotConnectionStatus()
        {
            if (robot1Controller?.IsConnected == true)
            {
                button_ConnectDisconnect.Text = "Disconnect";
                toolStripStatusLabel_RobotConnection.Text = "Connected";
                toolStripStatusLabel_RobotConnection.ForeColor = Color.Green;
            }
            else
            {
                button_ConnectDisconnect.Text = "Connect";
                toolStripStatusLabel_RobotConnection.Text = "Disconnected";
                toolStripStatusLabel_RobotConnection.ForeColor = Color.Red;
            }
        }

        private void button_ConnectDisconnect_Click(object sender, EventArgs e)
        {
            if (robot1Controller.IsConnected)
                RobotDisconnect();
            else
                RobotConnect();
        }

        private void button_Test_Click(object sender, EventArgs e)
        {
            TestConnection();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            robot1Controller.Dispose();
            robot1Vision.Dispose();
        }

        private void initToolStripMenuItem_Click(object sender, EventArgs e)
        {
            robot1Controller.Init();
        }

        private void powerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            robot1Controller.SetPower(true);
            //throw new NotImplementedException();
        }

        private void TestConnection()
        {
            throw new NotImplementedException();
        }

        private bool FreeModeState = false;
        private void button_Free_RB1_Click(object sender, EventArgs e)
        {
            FreeModeState = !FreeModeState;
            robot1Controller.SetFreeMode(FreeModeState);
        }

        private void freeModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FreeModeState = !FreeModeState;
            robot1Controller.SetFreeMode(FreeModeState);
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            robot1Controller.SetFreeMode(true);
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            robot1Controller.SetFreeMode(false);
        }

        private void loadTCSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            robot1Controller.LoadTCS();
        }

        private void startTCSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            robot1Controller.StartTCS();
        }

        private void stopTCSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            robot1Controller.StopTCS();
        }

        private void attachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            robot1Controller.SetAttach(true);
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisionConnect();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisionDisconnect();
        }

        private void singleAquireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisionAquireSingle();
        }

        private void liveStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            robot1Vision.LiveVideo(1);
        }

        private void liveStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            robot1Vision.StopLiveVideo();
        }
    }
}
