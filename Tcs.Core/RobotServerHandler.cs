using Precise.Common.Communication.Controllers;
using Precise.Common.Communication.Managers.TCS;
using Precise.Common.Communication.Protocols.GplComm;
using Precise.Common.Communication.Protocols.TCS;
using Precise.Common.Communication.Managers.JogControl;
using Precise.Common.Core.Language;
using Precise.Common.Core.Logging;
using System;
using System.Threading;
using System.Windows.Forms;
using Precise.Common.Core.Util;
using System.Diagnostics.Contracts;
using Precise.Common.Communication.Managers.Output;
using Precise.Common.Core.Services;

namespace Tcs.Core
{
    public class RobotServerHandler : IDisposable
    {
        public event EventHandler ConnectionChanged;
        public event EventHandler PowerStateChanged;
        public event EventHandler GplOutputUpdated;

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

        public JogControlManager jogControlManager { get; private set; }
        
        private LogService logService;
        private LanguageService languageService;
        private Communications commHandle;
        private ControllerHelper controllerHelper;
        private TCSManager tcsManager;
        private LocationManager locationManager;
        private ProfileManager profileManager;
        private OutputManager outputManager;
        private bool jogModeToggle = false;


        public RobotServerHandler()
        {
            logService = new LogService();
            languageService = new LanguageService(logService);
            commHandle = new Communications();
            controllerHelper = new ControllerHelper(commHandle);
            outputManager = new OutputManager(languageService,
                                       logService,
                                       controllerHelper);

            string tcsMacroDirectory = TcsHelper.GetTCSMacroFolder();

            tcsManager = new TCSManager(languageService,
                                        logService,
                                        controllerHelper,
                                        new TCSConnection(logService),
                                        tcsMacroDirectory);

            tcsManager.Controller.ConnectionStateChanged += Controller_ConnectionStateChanged;
            tcsManager.Controller.PowerStateGplEvent += Controller_PowerStateGplEvent;

            jogControlManager = new JogControlManager(languageService, logService, controllerHelper);

            LanguageUtils.LoadEmbeddedLanguageFile(languageService,
                                        typeof(ControllerHelper).Assembly,
                                        "Precise.Common.Communication", "DefaultLanguageKeys.xml");
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
                    outputManager.PropertyChanged += OutputManager_PropertyChanged;
                    outputManager.Enable();
                    //controllerHelper.OutputGplEvent +=
                }

                ConnectionChanged.Invoke(this, EventArgs.Empty);
                tcsManager.Enable();
                jogControlManager.SelectedAxisIndex = 1;
                jogControlManager.Enable();
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
                jogControlManager.Disable();
                tcsManager.Controller.ConnectionStateChanged -= Controller_ConnectionStateChanged;
                tcsManager.Controller.PowerStateGplEvent -= Controller_PowerStateGplEvent;

                if (tcsManager.IsConnected == true)
                {
                    tcsManager.Controller.Disconnect();
                    tcsManager.Disconnect();
                    
                }
                tcsManager.Disable();

                ConnectionChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Controller_ConnectionStateChanged(bool obj)
            => ConnectionChanged?.Invoke(this, EventArgs.Empty);

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

        public void ToggleFreeMode()
        {
            jogModeToggle = !jogModeToggle;
            RobotTcsCmds.SetFreeMode(tcsManager, jogModeToggle);
        }

        public void LoadTCS() 
            => TcsHelper.LoadTCS(tcsManager);

        public void StartTCS() 
            => TcsHelper.StartTCS(tcsManager);

        public void StopTCS() 
            => TcsHelper.StopTCS(tcsManager);

        public void SendCommand(string command)
            => TcsHelper.SendSingleCommand(tcsManager, command);

        public void NoOperation()
            => TcsHelper.SendSingleCommand(tcsManager, "NOP");


        private void Controller_PowerStateGplEvent(GPLEventObj obj)
        {
            if(obj.EventCode == GPLEventObj.GPLEvents.EventPowerState)
                PowerStateChanged?.Invoke(this, EventArgs.Empty);
            jogModeToggle = false;
        }

        public void JogJointMode()
            => jogControlManager.SetJointMode();

        public void JogWorldMode()
            => jogControlManager.SetWorldMode();

        public void JogToolMode()
            => jogControlManager.SetToolMode();


        public void ComputerMode()
            => jogControlManager.SetComputerControl();

        public void JogAxisNumber(int axisNumber)
            => jogControlManager.SelectedAxisIndex = axisNumber;

        public void JogPlus()
            => jogControlManager.JogStart_PositiveDirection();

        public void JogMinus()
            => jogControlManager.JogStart_NegativeDirection();
        public void JogStop()
            => jogControlManager.JogStop();

        public void JogPowerOn()
            => jogControlManager.EnablePower();

        public void JogPowerOff()
            => jogControlManager.DisablePower();

        public void JogFreeMode()
            => jogControlManager.SetFreeMode();

        public string[] GetJogAxis()
        {
            return jogControlManager.AvailableAxes;
        }

        public void SetVariable<T>(string variableName, T variableValue, string projectName)
            => controllerHelper.SetVariable<T>(variableName, variableValue, projectName);

        public T GetVariable<T>(string variableName, string projectName)
            => controllerHelper.GetVariable<T>(variableName, projectName);

        private void OutputManager_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Output")
                GplOutputUpdated.Invoke(this, EventArgs.Empty);
        }
        
        public string GetGplOutputMsgs()
        {
            return outputManager.Output;
        }
        
    }
}
