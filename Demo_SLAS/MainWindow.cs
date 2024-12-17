using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Tcs.Core;

namespace Demo_SLAS
{
    public partial class MainWindow : Form
    {
        private RobotServerHandler robot1Controller;
        private VisionServerHandler robot1Vision;

        private RobotServerHandler robot2Controller;
        private VisionServerHandler robot2Vision;

        private ProgramSettings programSettings;
        private SettingsWindow settingsWindow;

        private string robot1ControllerIP;
        private string robot1VisionIP;

        private string robot2ControllerIP;
        private string robot2VisionIP;

        public MainWindow()
        {
            InitializeComponent();
            InitializeSettings();
            UpdateConnectionStatusDisplays();

            robot1Controller = new RobotServerHandler();
            robot1Controller.ConnectionChanged += Event_ConnectionStatusChanged;
            //robot1Controller.ConnectionChanged += Event_PowerStateChanged;

            robot1Vision = new VisionServerHandler();
            robot1Vision.ConnectionChanged += Event_ConnectionStatusChanged;
            robot1Vision.ImageCaptured += RB1_Vision_ImageCaptured;

            robot2Controller = new RobotServerHandler();
            robot2Controller.ConnectionChanged += Event_ConnectionStatusChanged;
            //robot2Controller.ConnectionChanged += Event_PowerStateChanged;

            robot2Vision = new VisionServerHandler();
            robot2Vision.ConnectionChanged += Event_ConnectionStatusChanged;
            robot2Vision.ImageCaptured += RB2_Vision_ImageCaptured;
        }

        private void InitializeSettings()
        {
            var strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var strWorkPath = Path.GetDirectoryName(strExeFilePath);
            var settingsFilePath = Path.Combine(strWorkPath, "program.settings");
            programSettings = new ProgramSettings(settingsFilePath);
            ApplySettings(true);
        }

        private void ApplySettings(bool force = false)
        {
            if (programSettings.ApplySettngs || force)
            {
                programSettings.SaveSettings();
                robot1ControllerIP = programSettings.Robot1IP;
                robot1VisionIP = programSettings.Vision1IP;
                robot2ControllerIP = programSettings.Robot2IP;
                robot2VisionIP = programSettings.Vision2IP;
            }
            programSettings.ApplySettngs = false;
        }

        private void RB1_Vision_Connect()
        {
            UpdateConnectionStatusDisplays();
            if (robot1Vision.IsConnected == false)
            {
                robot1Vision.Connect(robot1VisionIP);
                UpdateConnectionStatusDisplays();
            }
        }

        private void RB2_Vision_Connect()
        {
            UpdateConnectionStatusDisplays();
            if (robot2Vision.IsConnected == false)
            {
                robot2Vision.Connect(robot2VisionIP);
                UpdateConnectionStatusDisplays();
            }
        }

        private void RB1_Vision_Disconnect()
        {
            robot1Vision.Disconnect();
            UpdateConnectionStatusDisplays();
        }

        private void RB2_Vision_Disconnect()
        {
            robot2Vision.Disconnect();
            UpdateConnectionStatusDisplays();
        }


        // Robot 1
        private void button_RB1_Connect_Click(object sender, EventArgs e)
            => RB1_Controller_Connect();

        private void button_RB1_Disconnect_Click(object sender, EventArgs e)
            => RB1_Controller_Disconnect();

        private void RB1_Controller_Disconnect()
            => robot1Controller.Disconnect();

        private void RB1_Controller_Connect()
            => robot1Controller.Connect(robot1ControllerIP);

        private void RB2_Controller_Disconnect()
            => robot2Controller.Disconnect();

        private void RB2_Controller_Connect()
            => robot2Controller.Connect(robot2ControllerIP);

        private void button_RB1_StartCycle_Click(object sender, EventArgs e)
            => robot1Controller.SendCommand("RunProgram");

        private void button_RB1_PauseProgram_Click(object sender, EventArgs e)
            => robot1Controller.SendCommand("PauseProgram");

        private void button_RB1_StopProcess_Click(object sender, EventArgs e)
            => robot1Controller.SendCommand("StopProgram");

        private void button_RB1_FreeMode_Click(object sender, EventArgs e)
            => robot1Controller.SetFreeMode(true);


        // Robot 2
        private void button_RB2_Connect_Click(object sender, EventArgs e)
            => RB2_Controller_Connect();

        private void button_RB2_Disconnect_Click(object sender, EventArgs e)
            => RB2_Controller_Disconnect();

        private void button_RB2_HighPower_Click(object sender, EventArgs e)
            => robot1Controller.SetPower(true);

        private void button_RB2_PartCycle_Click(object sender, EventArgs e)
            => robot2Controller.SendCommand("RunProgram");

        private void button_RB2_PauseProgram_Click(object sender, EventArgs e)
            => robot2Controller.SendCommand("PauseProgram");

        private void button_RB2_StopCycle_Click(object sender, EventArgs e)
            => robot2Controller.SendCommand("StopProgram");

        private void button_RB2_FreeMode_Click(object sender, EventArgs e)
            => robot2Controller.SetFreeMode(true);

        // Vision
        private void RB1_Vision_AquireSingle(int camera = 1)
            => robot1Vision.TriggerCamera(camera);

        private void RB2_Vision_AquireSingle(int camera = 1)
            => robot2Vision.TriggerCamera(camera);

        private void button_RB1_TriggerCamera_Click(object sender, EventArgs e)
            => RB1_Vision_AquireSingle();

        private void button_RB2_TriggerCamera_Click(object sender, EventArgs e)
            => RB2_Vision_AquireSingle();


        private void Event_ConnectionStatusChanged(object sender, EventArgs e)
        {
            pictureBox_RB1_LiveImage.Invoke(new Action(() => { 
                UpdateConnectionStatusDisplays(); 
            }));
        }


        private void RB1_Vision_ImageCaptured(object sender, Image img)
        {
            pictureBox_RB1_LiveImage.Invoke(new Action(() => { 
                RB1_Vision_UpdateImageDisplay(img); 
            }));
        }

        private void RB2_Vision_ImageCaptured(object sender, Image img)
        {
            pictureBox_RB1_LiveImage.Invoke(new Action(() =>{ 
                RB2_Vision_UpdateImageDisplay(img); 
            }));
        }

        public void RB1_Vision_UpdateImageDisplay(Image img)
        {
            string fileName = "ImageFromCamera1.bmp";
            if (pictureBox_RB1_LiveImage.Visible)
            {
                pictureBox_RB1_LiveImage.Visible = false;
                pictureBox_RB1_LiveImage.Image?.Dispose();
                File.Delete(fileName);
            }
            img.Save(fileName, ImageFormat.Bmp);
            img.Dispose();
            pictureBox_RB1_LiveImage.Image = Image.FromFile(fileName);

            pictureBox_RB1_LiveImage.Visible = true;
        }

        public void RB2_Vision_UpdateImageDisplay(Image img)
        {
            string fileName = "ImageFromCamera2.bmp";
            if (pictureBox_RB2_LiveImage.Visible)
            {
                pictureBox_RB2_LiveImage.Visible = false;
                pictureBox_RB2_LiveImage.Image?.Dispose();
                File.Delete(fileName);
            }
            img.Save(fileName, ImageFormat.Bmp);
            img.Dispose();
            pictureBox_RB2_LiveImage.Image = Image.FromFile(fileName);

            pictureBox_RB2_LiveImage.Visible = true;
        }

        public void UpdateConnectionStatusDisplays()
        {
            bool RB1Ctrl = (robot1Controller?.IsConnected)??false;
            bool RB2Ctrl = (robot2Controller?.IsConnected) ?? false;
            bool RB1Vis = (robot1Vision?.IsConnected) ?? false;
            bool RB2Vis = (robot2Vision?.IsConnected) ?? false;

            // RB 1 Controller
            label_RB1_ConnectionStatus.Text = RB1Ctrl ? "Connected" : "Disconnected";
            label_RB1_ConnectionStatus.ForeColor = RB1Ctrl ? Color.Green : Color.Red;
            toolStripStatusLabel_RB1_Controller_Status.Text = RB1Ctrl ? "Connected" : "Disconnected";
            toolStripStatusLabel_RB1_Controller_Status.ForeColor = RB1Ctrl ? Color.Green : Color.Red;

            // RB 1 Vision
            toolStripStatusLabel_RB1_Vision_Status.Text = RB1Vis ? "Connected" : "Disconnected";
            toolStripStatusLabel_RB1_Vision_Status.ForeColor = RB1Vis ? Color.Green : Color.Red;

            // RB 2 Controller
            label_RB2_ConnectionStatus.Text = RB2Ctrl ? "Connected" : "Disconnected";
            label_RB2_ConnectionStatus.ForeColor = RB2Ctrl ? Color.Green : Color.Red;
            toolStripStatusLabel_RB2_Controller_Status.Text = RB2Ctrl ? "Connected" : "Disconnected";
            toolStripStatusLabel_RB2_Controller_Status.ForeColor = RB2Ctrl ? Color.Green : Color.Red;

            // RB 2 Vision
            toolStripStatusLabel_RB2_Vision_Status.Text = RB2Vis ? "Connected" : "Disconnected";
            toolStripStatusLabel_RB2_Vision_Status.ForeColor = RB2Vis ? Color.Green : Color.Red;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            robot1Controller.ConnectionChanged -= Event_ConnectionStatusChanged;
            //robot1Controller.ConnectionChanged -= Event_PowerStateChanged;

            robot1Vision.ConnectionChanged -= Event_ConnectionStatusChanged;
            robot1Vision.ImageCaptured -= RB1_Vision_ImageCaptured;

            robot2Controller.ConnectionChanged -= Event_ConnectionStatusChanged;
            //robot2Controller.ConnectionChanged -= Event_PowerStateChanged;

            robot2Vision.ConnectionChanged -= Event_ConnectionStatusChanged;
            robot2Vision.ImageCaptured -= RB2_Vision_ImageCaptured;

            settingsWindow?.Close();

            robot1Controller?.Dispose();
            robot1Vision?.Dispose();

            robot2Controller?.Dispose();
            robot2Vision?.Dispose();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsWindow = new SettingsWindow(programSettings);
            settingsWindow.Show();
            settingsWindow.FormClosing += SettingsWindow_FormClosing;
        }

        private void SettingsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            settingsWindow.FormClosing -= SettingsWindow_FormClosing;
            ApplySettings();
        }

        // RB 1
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
            => RB1_Controller_Connect();
        
        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
            => RB1_Controller_Disconnect();
        
        private void startupToolStripMenuItem_Click(object sender, EventArgs e)
            => robot1Controller.StartTCS();
        

        private void initToolStripMenuItem_Click(object sender, EventArgs e)
            => robot1Controller.Init();
        
        private void attachToolStripMenuItem_Click(object sender, EventArgs e)
            => robot1Controller.SetAttach(true);
        
        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
            => robot1Controller.SetPower(true);
        
        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
            => robot1Controller.SetPower(false);
        
        private void freeModeOnToolStripMenuItem_Click(object sender, EventArgs e)
            => robot1Controller.SetFreeMode(true);
        
        private void freeModeOffToolStripMenuItem_Click(object sender, EventArgs e)
            => robot1Controller.SetFreeMode(false);
        
        private void connectToolStripMenuItem1_Click(object sender, EventArgs e)
            => RB1_Vision_Connect();
        
        private void disconnectToolStripMenuItem1_Click(object sender, EventArgs e)
            => RB1_Vision_Disconnect();
        

        // RB2
        private void connectToolStripMenuItem2_Click(object sender, EventArgs e)
            => RB2_Controller_Connect();
        

        private void disconnectToolStripMenuItem2_Click(object sender, EventArgs e)
            => RB2_Vision_Disconnect();
        
        private void startupToolStripMenuItem1_Click(object sender, EventArgs e)
            => robot2Controller.StartTCS();

        private void initToolStripMenuItem1_Click(object sender, EventArgs e)
            => robot2Controller.Init();
        
        private void attachToolStripMenuItem1_Click(object sender, EventArgs e)
            => robot2Controller.SetAttach(true);
        
        private void toolStripMenuItem_PowerEnable_Click(object sender, EventArgs e)
            => robot2Controller.SetPower(true);
        
        private void toolStripMenuItem_PowerDisable_Click(object sender, EventArgs e)
            => robot2Controller.SetPower(false);
        
        private void toolStripMenuItem_FreeModeOn_Click(object sender, EventArgs e)
            => robot2Controller.SetFreeMode(true);
        
        private void toolStripMenuItem_FreeModeOff_Click(object sender, EventArgs e)
            => robot2Controller.SetFreeMode(false);
        
        private void connectToolStripMenuItem3_Click(object sender, EventArgs e)
            => RB2_Vision_Connect();
        
        private void disconnectToolStripMenuItem3_Click(object sender, EventArgs e)
            => RB2_Vision_Disconnect();
        

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RB1_Controller_Connect();
            RB2_Controller_Connect();
            RB1_Vision_Connect();
            RB2_Vision_Connect();
            robot1Controller.StartTCS();
            robot2Controller.StartTCS();
            robot1Controller.Init();
            robot2Controller.Init();
            System.Threading.Thread.Sleep(5000);
            robot1Controller.SendCommand("RunProgram");
            robot2Controller.SendCommand("RunProgram");
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            robot1Controller.SendCommand("StopProgram");
            robot2Controller.SendCommand("StopProgram");
        }

        private void Event_PowerStateChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void radioButton_SortA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_SortA.Checked)
            {
                robot1Controller.SendCommand("ChangeSortA");
            }
        }

        private void radioButton_SortB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_SortB.Checked)
            {
                robot1Controller.SendCommand("ChangeSortB");
            }
        }

        private void teachHotelRB2_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            robot1Controller.SendCommand("TeachHotel");
        }

        private void teachHotelRB2_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            robot2Controller.SendCommand("TeachHotel");
        }
    }
}
