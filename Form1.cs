using Precise.Common.Communication.Controllers;
using Precise.Common.Communication.Managers.TCS;
using Precise.Common.Communication.Protocols.GplComm;
using Precise.Common.Communication.Protocols.TCS;
using Precise.Common.Core.Language;
using Precise.Common.Core.Logging;
//using Precise.Wpf.Common
using System;
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
                    button_ConnectDisconnect.Text = "Connect";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private string SendSingleCommand(string command, int timeout = 5000, int sleep = 1000)
        {
            if (controllerHelper.IsActive)
            {
                tcsManager.CommandText = command;
                tcsManager.SendCommand();
                TcsHelper.Wait(() => !tcsManager.IsBackgroundExecuting, timeout);
                System.Threading.Thread.Sleep(sleep);
                return tcsManager.CommandResponse;
            }
            return string.Empty;
        }

        private void initToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendSingleCommand("Attach 1", 5000);
            SendSingleCommand("hp 1", 5000, 5000);
            SendSingleCommand("homeAll", 5000, 5000);
            SendSingleCommand("waitForEom", 5000);

        }

        private void powerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string resp = SendSingleCommand("hp", 5000);
            if(tcsManager.Controller.OperationInfo.IsPowerEnabled)
                SendSingleCommand("hp 0", 5000);
            else
                SendSingleCommand("hp 1", 5000);
        }

        private void TestConnection()
        {
            if (controllerHelper.IsActive)
            {
                //tcsManager.CommandText = "Attach 1";
                //tcsManager.SendCommand();
                //TcsHelper.Wait(() => !tcsManager.IsBackgroundExecuting, 3000);
                //Console.WriteLine(tcsManager.CommandResponse);
                //tcsManager.CommandText = "hp 1";
                //tcsManager.SendCommand();
                //TcsHelper.Wait(() => !tcsManager.IsBackgroundExecuting, 3000);
                //Console.WriteLine(tcsManager.CommandResponse);
            }
        }
    }
}
