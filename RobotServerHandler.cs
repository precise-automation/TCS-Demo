using Precise.Common.Communication.Controllers;
using Precise.Common.Communication.Managers.TCS;
using Precise.Common.Communication.Protocols.GplComm;
using Precise.Common.Communication.Protocols.TCS;
using Precise.Common.Communication.Vision.VisionEngineComm;
using Precise.Common.Core.Language;
using Precise.Common.Core.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

        private LogService logService;
        private LanguageService languageService;
        private Communications commHandle;
        private ControllerHelper controllerHelper;
        private TCSManager tcsManager;


        public RobotServerHandler()
        {
            InitializeGdsComponents();
        }

        void IDisposable.Dispose()
        {
            Disconnect();
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
            tcsManager.Controller.ConnectionStateChanged += Controller_ConnectionStateChanged;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        private void Controller_ConnectionStateChanged(bool obj)
        {
            ConnectionChanged.Invoke(this, EventArgs.Empty);
        }

        public void Connect(string ipAddress = "192.168.0.1")
        {
            try
            {
                if (tcsManager.IsConnected == false)
                {
                    tcsManager.Controller.Connect(ipAddress);
                    RobotTcsCmds.AttachRobot(tcsManager);
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

        public void Init() => RobotTcsCmds.RobotInit(tcsManager);
        
        public void SetPower(bool powerState = true)
        {
            RobotTcsCmds.SetHighPower(tcsManager, powerState);
            Thread.Sleep(250);
        }

        public void SetAttach(bool attach = true) => RobotTcsCmds.AttachRobot(tcsManager, attach);
        public void SetFreeMode(bool freeAllJoints = true) => RobotTcsCmds.SetFreeMode(tcsManager, freeAllJoints);
        

        public void LoadTCS() => TcsHelper.LoadTCS(tcsManager);
        public void CompileTCS() => throw new NotImplementedException();
        public void StartTCS() => TcsHelper.StartTCS(tcsManager);
        public void StopTCS() => TcsHelper.StopTCS(tcsManager);


    }
}
