using Precise.Common.Communication.Controllers;
using Precise.Common.Communication.Managers.TCS;
using Precise.Common.Communication.Protocols.GplComm;
using Precise.Common.Communication.Protocols.TCS;
using Precise.Common.Core.Language;
using Precise.Common.Core.Logging;
//using Precise.Wpf.Common
using System;
using System.Drawing;
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

        private ProgramSettings programSettings;

        private string controllerIP;

        public Form1()
        {
            InitializeComponent();
            InitializeGdsComponents();
            InitializeSettings();
            UpdateConnectionStatus();
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

            // Not sure this is needed so removing for now. May be needed in the future
            /* 
            LanguageUtils.LoadEmbeddedLanguageFile(languageService,
                                        typeof(LanguageHelper).Assembly,
                                        "Precise.Wpf.Common.Resources", "DefaultLanguageKeysGDS.xml");

            LanguageUtils.LoadEmbeddedLanguageFile(languageService,
                                                    typeof(LanguageHelper).Assembly,
                                                    "Precise.Wpf.Common.Resources", "DefaultLanguageKeysCommon.xml");

            LanguageUtils.LoadEmbeddedLanguageFile(languageService,
                                                    typeof(LanguageHelper).Assembly,
                                                    "Precise.Wpf.Common.Resources", "DefaultLanguageKeysVision.xml");

            LanguageUtils.LoadEmbeddedLanguageFile(languageService,
                                                    typeof(ControllerHelper).Assembly,
                                                    "Precise.Common.Communication", "DefaultLanguageKeys.xml");

            LanguageUtils.LoadEmbeddedLanguageFile(languageService,
                                                   typeof(StatementRegistry).Assembly,
                                                   "Precise.Common.Code", "DefaultLanguageKeys.xml");

            LanguageHelper.LanguageService = languageService;
            EnumItemSourceStringConverter.LanguageService = languageService;
            */
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


        private void Connect()
        {
            try
            {
                if (tcsManager.IsConnected == false)
                {
                    tcsManager.Controller.Connect(controllerIP);
                    button_ConnectDisconnect.Text = "Disconnect";
                    UpdateConnectionStatus(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Disconnect()
        {
            try
            {
                if (tcsManager.IsConnected == true)
                {
                    tcsManager.Controller.Disconnect();
                    tcsManager.Disconnect();
                    UpdateConnectionStatus(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateConnectionStatus(bool connected = false)
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
                Disconnect();
            else
                Connect();
        }

        private void button_Test_Click(object sender, EventArgs e)
        {
            TestConnection();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }

        private string SendSingleCommand(string command, int sleep = 1000, int timeout = 5000)
        {
            if (controllerHelper.IsActive)
            {
                tcsManager.CommandText = command;
                Console.WriteLine(string.Format("<-- {0}", command));
                tcsManager.SendCommand();
                TcsHelper.Wait(() => !tcsManager.IsBackgroundExecuting, timeout);
                System.Threading.Thread.Sleep(sleep);
                Console.WriteLine(string.Format("--> {0}", tcsManager.CommandResponse));
                return tcsManager.CommandResponse;
            }
            return string.Empty;
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

        private void button_Free_RB1_Click(object sender, EventArgs e)
        {
            RobotTcsCmds.ToggleFreeMode(tcsManager);
        }

        private void loadTCSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TcsProjectManager.LoadTCS(tcsManager);
        }

        private void startTCSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TcsProjectManager.LoadTCS(tcsManager);
        }

        private void stopTCSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TcsProjectManager.StopTCS(tcsManager);
        }
    }
}
