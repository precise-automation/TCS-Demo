using Precise.Common.Communication.Controllers;
using Precise.Common.Communication.Managers.JogControl;
using Precise.Common.Communication.Protocols.GplComm;
using Precise.Common.Core.Language;
using Precise.Common.Core.Logging;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Tcs.Core;

namespace Demo_Example4
{
    public partial class MainWindow : Form
    {
        private RobotServerHandler robot1Controller;
        private VisionServerHandler robot1Vision;
        private JogControlManager jogControlManager;

        private ProgramSettings programSettings;
        private SettingsWindow settingsWindow;

        private string robot1ControllerIP;
        private string robot1VisionIP;

        private bool isJogging = false;


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

            var logService = new LogService();
            var languageService = new LanguageService(logService);
            var commHandle = new Communications();
            var controllerHelper = new ControllerHelper(commHandle);
            jogControlManager = new JogControlManager(languageService, logService, controllerHelper);

            string[] vals = {"0", "1", "2", "3", "4","5" };
            comboBox_AxisSelection.Items.AddRange(vals);
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

        private void RB1_Vision_Disconnect()
        {
            robot1Vision.Disconnect();
            UpdateConnectionStatusDisplays();
        }


        private void RB1_Vision_AquireSingle(int camera = 1)
            => robot1Vision.TriggerCamera(camera);


        private void button_RB1_TriggerCamera_Click(object sender, EventArgs e)
            => RB1_Vision_AquireSingle();

        private void button_RB1_Connect_Click(object sender, EventArgs e)
            => RB1_Controller_Connect();

        private void button_RB1_Disconnect_Click(object sender, EventArgs e)
            => RB1_Controller_Disconnect();

        private void RB1_Controller_Disconnect()
            => robot1Controller.Disconnect();

        private void RB1_Controller_Connect()
            => robot1Controller.Connect(robot1ControllerIP);

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


        public void RB1_Vision_UpdateImageDisplay(Image img)
        {
            if (tabControl1.SelectedTab.Text.Contains("Vision 1") == false)
                return;

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


        public void UpdateConnectionStatusDisplays()
        {
            bool RB1Ctrl = (robot1Controller?.IsConnected)??false;
            bool RB1Vis = (robot1Vision?.IsConnected) ?? false;

            // RB 1 Controller
            label_RB1_ConnectionStatus.Text = RB1Ctrl ? "Connected" : "Disconnected";
            label_RB1_ConnectionStatus.ForeColor = RB1Ctrl ? Color.Green : Color.Red;
            toolStripStatusLabel_RB1_Controller_Status.Text = RB1Ctrl ? "Connected" : "Disconnected";
            toolStripStatusLabel_RB1_Controller_Status.ForeColor = RB1Ctrl ? Color.Green : Color.Red;

            // RB 1 Vision
            toolStripStatusLabel_RB1_Vision_Status.Text = RB1Vis ? "Connected" : "Disconnected";
            toolStripStatusLabel_RB1_Vision_Status.ForeColor = RB1Vis ? Color.Green : Color.Red;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            robot1Controller.ConnectionChanged -= Event_ConnectionStatusChanged;
            //robot1Controller.ConnectionChanged -= Event_PowerStateChanged;

            robot1Vision.ConnectionChanged -= Event_ConnectionStatusChanged;
            robot1Vision.ImageCaptured -= RB1_Vision_ImageCaptured;

            settingsWindow?.Close();

            robot1Controller?.Dispose();
            robot1Vision?.Dispose();
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





        private void button_JogStop_Click(object sender, EventArgs e)
        {
            robot1Controller.JogStop();
            isJogging = false;
        }

        private void comboBox_AxisSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            int axis = comboBox_AxisSelection.SelectedIndex;
            robot1Controller.JogAxisNumber(axis);
        }

        private void button_JogPowerOn_Click(object sender, EventArgs e)
        {
            robot1Controller.JogPowerOn();
        }

        private void button_JogPowerOff_Click(object sender, EventArgs e)
        {
            robot1Controller.JogPowerOff();
        }

        private void button_JogPlus_MouseLeave(object sender, EventArgs e)
        {
            stopJogging();
        }

        private void button_JogPlus_MouseUp(object sender, MouseEventArgs e)
        {
            stopJogging();
        }

        private void buttonJogMinus_MouseLeave(object sender, EventArgs e)
        {
            stopJogging();
        }

        private void buttonJogMinus_MouseUp(object sender, MouseEventArgs e)
        {
            stopJogging();
        }

        private void stopJogging()
        {
            if (isJogging)
                robot1Controller.JogStop();
            isJogging = false;
        }

        private void button_JogPlus_MouseDown(object sender, MouseEventArgs e)
        {
            robot1Controller.JogPlus();
            isJogging = true;
        }

        private void buttonJogMinus_MouseDown(object sender, MouseEventArgs e)
        {
            robot1Controller.JogMinus();
            isJogging = true;
        }

        private void comboBox_JogMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_JogMode.Text.ToLower() == "computer")
                robot1Controller.ComputerMode();
            else if (comboBox_JogMode.Text.ToLower() == "joint")
                robot1Controller.JogJointMode();
            else if (comboBox_JogMode.Text.ToLower() == "world")
                robot1Controller.JogWorldMode();
            else if (comboBox_JogMode.Text.ToLower() == "tool")
                robot1Controller.JogToolMode();
            else if (comboBox_JogMode.Text.ToLower() == "free")
                robot1Controller.JogFreeMode();

            System.Threading.Thread.Sleep(250);

            //jogControlManager.PropertyChanged("")

            var axis = robot1Controller.GetJogAxis();
            comboBox_AxisSelection.Items.Clear();
            comboBox_AxisSelection.Items.AddRange(axis);
            comboBox_AxisSelection.SelectedIndex = 0;
        }
    }
}
