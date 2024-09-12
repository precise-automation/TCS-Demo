using Precise.Common.Communication.Controllers;
using Precise.Common.Communication.Managers.TCS;
using System;
using System.Diagnostics;
using System.Threading;

namespace Brooks_TCS_Demo
{
    public static class RobotTcsCmds
    {

        public static bool RobotInit(TCSManager tcsManager)
        {
            bool status = true;
            try
            {
                status &= EnableHighPower(tcsManager);
                status &= AttachRobot(tcsManager);
                status &= HomeRobot(tcsManager);
            }
            catch (Exception ex)
            {
                return false;
            }
            return status;
        }

        public static bool EnableHighPower(TCSManager tcsManager)
        {
            TcsHelper.SendSingleCommand(tcsManager, "hp 1");
            bool result = WaitForRobotPowerState(tcsManager, PowerAutoExecStates.GPLReady, 10 * 1000);
            Thread.Sleep(250);
            return result;
        }
        public static bool AttachRobot(TCSManager tcsManager)
        {
            TcsHelper.SendSingleCommand(tcsManager, "Attach 1");
            return WaitForRobotPowerState(tcsManager, PowerAutoExecStates.GPLAttached);
        }
        public static bool HomeRobot(TCSManager tcsManager)
        {
            bool state;
            TcsHelper.SendSingleCommand(tcsManager, "homeAll", 1000);
            if (WaitForRobotPowerState(tcsManager, PowerAutoExecStates.RobotsHoming, 5 * 1000) == false)
                return false;
            if (WaitForRobotPowerState(tcsManager, PowerAutoExecStates.GPLReady, 30 * 1000) == false)
                return false;
            return true;
        }

        public static bool WaitForRobotPowerState(TCSManager tcsManager, PowerAutoExecStates state = PowerAutoExecStates.GPLReady, int timeoutMS = 10000)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (stopwatch.ElapsedMilliseconds <= timeoutMS)
            {
                if (tcsManager.Controller.OperationInfo.CurrentPowerAutoExecState == state)
                    return true;
                Thread.Sleep(10);
            }
            return false;
        }

        public static bool WaitForNotRobotPowerState(TCSManager tcsManager, PowerAutoExecStates state = PowerAutoExecStates.GPLReady, int timeoutMS = 30000)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (stopwatch.ElapsedMilliseconds <= timeoutMS)
            {
                if (tcsManager.Controller.OperationInfo.CurrentPowerAutoExecState != state)
                    return true;
                Thread.Sleep(10);
            }
            return false;
        }

        public static bool ToggleFreeMode(TCSManager tcsManager)
        {
            try
            {
                if (tcsManager.Controller.IsActive)
                {
                    if (tcsManager.Controller.OperationInfo.IsJogModeEnabled)
                        TcsHelper.SendSingleCommand(tcsManager, "Free -1");
                    else
                    {
                        TcsHelper.SendSingleCommand(tcsManager, "Attach 1");
                        TcsHelper.SendSingleCommand(tcsManager, "FreeMode 0");
                    }
                }
                return true;
            }
            catch { return false; }
        }

        public static bool ToggleHighPower(TCSManager tcsManager)
        {
            try
            {
                if (tcsManager.Controller.IsActive)
                {
                    if (tcsManager.Controller.OperationInfo.IsPowerEnabled)
                        TcsHelper.SendSingleCommand(tcsManager, "hp 0", 500);
                    else
                        EnableHighPower(tcsManager);
                }
                return true;
            }
            catch { return false; }
        }


    }
}
