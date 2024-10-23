using Precise.Common.Communication.Controllers;
using Precise.Common.Communication.Managers.TCS;
using Precise.Common.Communication.Protocols.GplComm;
using Precise.Common.Communication.Protocols.TCS;
using Precise.Common.Core.Language;
using Precise.Common.Core.Logging;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Brooks_TCS_Demo
{
    public class RobotServerHandler : IDisposable
    {
        public event EventHandler ConnectionChanged;
        public bool IsConnected
        {
            get => tcsManager.IsConnected ;
        }

        public LocationManager LocationManager
        {
            get
            {
                if (locationManager == null)
                {
                    locationManager = new LocationManager(tcsManager);
                }
                return locationManager;
            }
        }

        public ProfileManager ProfileManager
        {
            get
            {
                if (profileManager == null)
                {
                    profileManager = new ProfileManager(tcsManager);
                }
                return profileManager;
            }
        }

        private LogService logService;
        private LanguageService languageService;
        private Communications commHandle;
        private ControllerHelper controllerHelper;
        private TCSManager tcsManager;
        private LocationManager locationManager;
        private ProfileManager profileManager;


        public RobotServerHandler()
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

            tcsManager.Controller.ConnectionStateChanged += Controller_ConnectionStateChanged;

        }

        void IDisposable.Dispose()
            => this.Dispose();

        public void Dispose()
            => Disconnect();

        public void Connect(string ipAddress = "192.168.0.1")
        {
            try
            {
                if (tcsManager.IsConnected == false)
                {
                    tcsManager.Controller.Connect(ipAddress);
                    if (TcsHelper.IsTcsRunning(tcsManager) == false)
                        MessageBox.Show("TCS Not Running On Target Controller", "Warning");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Disconnect()
        {
            try
            {
                if (tcsManager.IsConnected == true)
                {
                    tcsManager.Controller.Disconnect();
                    tcsManager.Disconnect();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Controller_ConnectionStateChanged(bool obj)
            => ConnectionChanged.Invoke(this, EventArgs.Empty);

        public void Init() 
            => RobotTcsCmds.RobotInit(tcsManager);
        
        public void SetPower(bool powerState = true)
        {
            RobotTcsCmds.SetHighPower(tcsManager, powerState);
            Thread.Sleep(250);
        }

        public void SetAttach(bool attach = true) 
            => RobotTcsCmds.AttachRobot(tcsManager, attach);

        public void SetFreeMode(bool freeAllJoints = true) 
            => RobotTcsCmds.SetFreeMode(tcsManager, freeAllJoints);

        public void LoadTCS() 
            => TcsHelper.LoadTCS(tcsManager);

        public void StartTCS() 
            => TcsHelper.StartTCS(tcsManager);

        public void StopTCS() 
            => TcsHelper.StopTCS(tcsManager);

    }
}
