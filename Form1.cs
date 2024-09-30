using Precise.Common.Communication.Controllers;
using Precise.Common.Communication.Managers.TCS;
using Precise.Common.Communication.Protocols.GplComm;
using Precise.Common.Communication.Protocols.TCS;
using Precise.Common.Communication.Protocols.VisionStream.Server;
using Precise.Common.Communication.Vision.VisionEngineComm;
using Precise.Common.Communication.VisionEngineComm.Vision.Results;
using Precise.Common.Core.Language;
using Precise.Common.Core.Logging;
//using Precise.Wpf.Common
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Brooks_TCS_Demo
{
    public partial class Form1 : Form
    {
        private LogService logService;
        private LanguageService languageService;
        private Communications commHandle;
        private ControllerHelper controllerHelper;
        private TCSManager tcsManager;

        Func<VisionToolInstance[]> visionToolInstanceFinder;
        private ResultConverterFactory resultConverterFactory;
        private VisionEngineClientService visionEngineClientService;
        private VisionServerHandler visionServerHandler;
        private VisionDataClient visionDataClient;

        private Image cameraImageDisplay;

        private ProgramSettings programSettings;

        private string controllerIP;

        public Form1()
        {
            InitializeComponent();
            InitializeGdsComponents();
            InitializeSettings();
            UpdateRobotConnectionStatus();
            InitializeVisionComponents();
            UpdateVisionConnectionStatusDisplay();
        }

        public void InitializeGdsComponents()
        {
            logService = new LogService();
            languageService = new LanguageService(logService);
            commHandle = new Communications();
            controllerHelper = new ControllerHelper(commHandle);

            string tcsMacroDirectory = TcsHelper.GetTCSMacroFolder();
            tcsManager = new TCSManager(languageService,
                                        logService,
                                        controllerHelper,
                                        new TCSConnection(logService),
                                        tcsMacroDirectory);

        }

        private void InitializeSettings()
        {
            string settingsFilePath = "settings.json";
            programSettings = new ProgramSettings(settingsFilePath);
            LoadSettings();
        }

        private void LoadSettings(bool forceReload = false)
        {
            if(forceReload)
                programSettings.LoadSettings();

            controllerIP = programSettings.Get<string>("ControllerIP", "192.168.0.1");

            //    Example Code:
            //    int volume = programSettings.Get<int>("volume", 50); // Default to 50 if not found
            //    string theme = programSettings.Get<string>("theme", "light"); // Default to "light"
        }

        private void SaveSettings()
        {
            programSettings.Set("ControllerIP", controllerIP);
            programSettings.SaveSettings();

            //    Example Code: 
            //    programSettings.Set("volume", 75);
            //    programSettings.Set("theme", "dark");
        }

        private void InitializeVisionComponents()
        {
            visionToolInstanceFinder = () =>
            {
                return visionEngineClientService.VisionToolInstances.ToArray();
            };

            var resultsConverterFactory = new ResultConverterFactory(languageService, logService, visionToolInstanceFinder);

            visionEngineClientService = new VisionEngineClientService(languageService, logService, resultsConverterFactory);
            visionServerHandler = new VisionServerHandler(visionEngineClientService);

            visionDataClient = new VisionDataClient(logService, 0);
        }

        private void VisionConnect()
        {
            UpdateVisionConnectionStatusDisplay();
            string visionServerIP = "192.168.0.200";
            if (visionEngineClientService.IsConnected == false)
            {
                visionEngineClientService.ErrorDetected += VisionEngineClientService_ErrorDetected;
                visionEngineClientService.Connect(visionServerIP);
                visionEngineClientService.ImageUpdated += VisionEngineClientService_ImageUpdated;
                UpdateVisionConnectionStatusDisplay(true);
            }
        }

        private void VisionEngineClientService_ErrorDetected(Exception obj)
        {
            MessageBox.Show(obj.Message, "Vision Error");
        }

        private void VisionDisconnect()
        {
            UpdateVisionConnectionStatusDisplay();
            visionEngineClientService.ImageUpdated -= VisionEngineClientService_ImageUpdated;
            if (visionEngineClientService.IsConnected)
                visionEngineClientService.Disconnect();
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

        private void VisionEngineClientService_ImageUpdated(object sender, ImageUpdatedArguments e)
        {
            
        }

        private void VisionAquireSingle(int camera = 1)
        {
            visionServerHandler.TriggerCamera(camera);
        }


        private void RobotConnect()
        {
            try
            {
                if (tcsManager.IsConnected == false)
                {
                    tcsManager.Controller.Connect(controllerIP);
                    button_ConnectDisconnect.Text = "Disconnect";
                    UpdateRobotConnectionStatus(true);
                    RobotTcsCmds.AttachRobot(tcsManager);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RobotDisconnect()
        {
            try
            {
                if (tcsManager.IsConnected == true)
                {
                    tcsManager.Controller.Disconnect();
                    tcsManager.Disconnect();
                    UpdateRobotConnectionStatus(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateRobotConnectionStatus(bool connected = false)
        {
            if (connected)
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
            if (tcsManager.IsConnected)
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
            RobotDisconnect();
            VisionDisconnect();
        }

        private void initToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controllerHelper.IsActive)
            {
                RobotTcsCmds.RobotInit(tcsManager);
            }
        }

        private void powerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TestConnection()
        {

            
        }

        private bool FreeModeState = false;
        private void button_Free_RB1_Click(object sender, EventArgs e)
        {
            FreeModeState = !FreeModeState;
            RobotTcsCmds.SetFreeMode(tcsManager, FreeModeState);
        }

        private void freeModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FreeModeState = !FreeModeState;
            RobotTcsCmds.SetFreeMode(tcsManager, FreeModeState);
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RobotTcsCmds.SetFreeMode(tcsManager, true);
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RobotTcsCmds.SetFreeMode(tcsManager, false);
        }

        private void loadTCSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TcsHelper.LoadTCS(tcsManager);
        }

        private void startTCSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TcsHelper.LoadTCS(tcsManager);
        }

        private void stopTCSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TcsHelper.StopTCS(tcsManager);
        }

        private void attachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RobotTcsCmds.AttachRobot(tcsManager);
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
            visionEngineClientService.LiveVideo(1);
        }

        private void liveStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visionEngineClientService.StopLiveVideo();
        }
    }
}
